using MobileStore.DTO;
using MobileStore.BUS;
using MobileStore.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MobileStore.GUI
{
    public partial class importProForm : Form
    {
        productBUS product_BUS = new productBUS();
        categoryBUS cate_BUS = new categoryBUS();
        supplierBUS supp_BUS = new supplierBUS();
        importBUS importBUS = new importBUS();
        importDetailBUS impDe_BUS = new importDetailBUS();
        String getName = "";
        String getId = "";
        int finalPrice = 0;
        int priceOneRow = 0;
        public importProForm(String name, String id)
        {
            getName = name;
            getId = id;
            InitializeComponent();
            txtAccName.Text = getName + "(" + getId + ")";
        }
        void HienThiSanPham()
        {
            lsvProduct.Items.Clear();
            DataTable dt = product_BUS.LayDSSanPham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvProduct.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        void HienThiMNCC()
        {
            DataTable dt = product_BUS.LayMaNCC();
            cmbSuppName.DataSource = dt;
            cmbSuppName.DisplayMember = "SupplierID";
            cmbSuppName.ValueMember = "SupplierID";
        }
        public void addImport()
        {
            try
            {
                // Assuming the DataTable has a column named "SuppID" for supplier ID
                DataTable supList = supp_BUS.LayDSNhaCC();

                // Make sure there are rows in the DataTable
                if (supList.Rows.Count == 0)
                {
                    MessageBox.Show("Không có nhà cung cấp nào.");
                    return;
                }

                // Make sure there is a selected item in cmbSuppName
                if (cmbSuppName.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp");
                    return;
                }
                DataRow selectedRow = supList.Rows[cmbSuppName.SelectedIndex];
                String suppid = selectedRow["SupplierID"].ToString();
                //String importID = txtImportID.Text;
                string importID = "PN" + (importBUS.LayMaPNMax() + 1).ToString();
                String empID = getId;
                string importDate = dtpImport.Value.ToString("MM/dd/yyyy");
                importDTO imp = new importDTO(importID, suppid, importDate, empID);

                if (importBUS.ThemNhapHang(imp))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void addImportDetail()
        {
            for (int i = 0; i < lsvImport.Items.Count; i++)
            {
                //MessageBox.Show("Test:" + lsvImport.Items[i].SubItems[0].Text);
                String importID = txtImportID.Text;
                String productID = lsvImport.Items[i].SubItems[0].Text;
                int quantity = int.Parse(lsvImport.Items[i].SubItems[3].Text);
                int price = int.Parse(lsvImport.Items[i].SubItems[5].Text);

                Boolean tmp = impDe_BUS.CheckChiTietNhapHang(importID, productID);
                Boolean checkProductid = product_BUS.CheckProductID(productID);

                if (tmp)
                {
                    importDetailDTO impDe = new importDetailDTO(importID, productID, quantity, price);
                    Boolean a = impDe_BUS.CapNhatChiTietHD(impDe);
                    Boolean b = product_BUS.updateQuantityPlus(productID, quantity);
                }
                else
                {
                    importDetailDTO impDe = new importDetailDTO(importID, productID, quantity, price);
                    Boolean a = impDe_BUS.ThemChiTietNhapHang(impDe);
                    Boolean b = product_BUS.updateQuantityPlus(productID, quantity);
                }
            }
        }
        public void updateQuantity()
        {
            if (lsvProduct.SelectedItems.Count > 0)
            {
                // Lấy chỉ mục của dòng đang được chọn trong ListView
                int curIndex = lsvProduct.SelectedIndices[0];

                // Lấy giá trị cũ của số lượng từ cột thứ 4 trong dòng đang được chọn
                int oldQuantity = int.Parse(lsvProduct.Items[curIndex].SubItems[4].Text);

                // Lấy giá trị mới từ TextBox txtOldQuantity và cộng với giá trị cũ
                int newQuantity = oldQuantity + int.Parse(txtOldQuantity.Text);

                // Cập nhật giá trị mới vào cột thứ 4 trong dòng đang được chọn
                lsvProduct.Items[curIndex].SubItems[4].Text = newQuantity.ToString();
            }

        }
        public Boolean checkOldQuantity(String oldQuantity)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            Regex rg1 = new Regex(checkNum);
            Regex rg2 = new Regex(checkChar);
            if (rg1.IsMatch(oldQuantity) == false && rg2.IsMatch(oldQuantity) == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Sai định dạng,vui lòng nhập lại!!");
                txtOldQuantity.Text = "";
            }
            return check;
        }
        public Boolean checkImportID(String importID)
        {
            Boolean check = false;
            String checkImport = @"(PN)\d{0,9}";
            Regex rg = new Regex(checkImport);
            if (rg.IsMatch(importID) && importBUS.CheckImport(importID) == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Sai cú pháp hoặc trùng mã , vui lòng nhập lại!!");
            }
            return check;
        }

        private void lsvProduct_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem selectedCake = e.Item;
                txtOldProductId.Text = selectedCake.SubItems[0].Text; // Giả sử cột đầu tiên là cột "Mã"
                txtOldProductName.Text = selectedCake.SubItems[1].Text; // Giả sử cột thứ hai là cột "Tên"
                txtOldCateId.Text = selectedCake.SubItems[3].Text; // Giả sử cột thứ ba là cột "Loại"
                txtOldPrice.Text = selectedCake.SubItems[2].Text; // Giả sử cột thứ tư là cột "Đơn giá"
            }
        }

        private void btnAddOldCake_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldQuantity.Text) || txtOldQuantity.Text.Equals("0"))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
            }
            else if (checkOldQuantity(txtOldQuantity.Text))
            {
                txtEmpName.Text = txtAccName.Text;
                dtpImport.Value = DateTime.Now;
                // Set dữ liệu cho bảng import
                int unitPrice = int.Parse(txtOldPrice.Text);
                int quantity = int.Parse(txtOldQuantity.Text);

                // Kiểm tra và cập nhật giá trị của các trường
                if (string.IsNullOrEmpty(txtOldProductId.Text) || string.IsNullOrEmpty(txtOldCateId.Text) ||
                    string.IsNullOrEmpty(txtOldProductName.Text) || string.IsNullOrEmpty(txtOldQuantity.Text) ||
                    string.IsNullOrEmpty(txtOldPrice.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm");
                    return;
                }

                // Thêm cột vào ListView nếu chưa được thêm
                if (lsvImport.Columns.Count == 0)
                {
                    lsvImport.Columns.Add("Mã");
                    lsvImport.Columns.Add("Loại");
                    lsvImport.Columns.Add("Tên");
                    lsvImport.Columns.Add("Số lượng");
                    lsvImport.Columns.Add("Đơn giá");
                    lsvImport.Columns.Add("Thành tiền");
                }

                // Thêm dữ liệu vào ListView
                ListViewItem item = new ListViewItem(txtOldProductId.Text);
                item.SubItems.Add(txtOldCateId.Text);
                item.SubItems.Add(txtOldProductName.Text);
                item.SubItems.Add(txtOldQuantity.Text);
                item.SubItems.Add(txtOldPrice.Text);
                item.SubItems.Add((unitPrice * quantity).ToString());

                lsvImport.Items.Add(item);

                // Đảm bảo rằng ListView hiển thị đúng cách
                lsvImport.View = View.Details;
                lsvImport.GridLines = true;
                lsvImport.FullRowSelect = true;
                lsvImport.Columns[0].Width = 200;


                // Tính tổng tiền
                finalPrice += unitPrice * quantity;
                txtPriceAll.Text = finalPrice.ToString();
                txtPricePro.Text = finalPrice.ToString();

                // Cập nhật lại bảng sản phẩm
                updateQuantity();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPriceAll.Text = "";
            txtPricePro.Text = "";
            dtpImport.Value = DateTime.Now;
            finalPrice = 0;
            lsvImport.Items.Clear();
            lsvProduct.Items.Clear();
            HienThiSanPham();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (checkImportID(txtImportID.Text) && txtImportID.Text.Equals("") == false)
            {
                addImport();
                addImportDetail();
                txtPriceAll.Text = "";
                txtPricePro.Text = "";
                dtpImport.Value = DateTime.Now;
                finalPrice = 0;
                lsvImport.Items.Clear();
                lsvProduct.Items.Clear();
                HienThiSanPham();
            }
        }

        private void importProForm_Load(object sender, EventArgs e)
        {
            lsvProduct.View = View.Details;
            lsvProduct.GridLines = true;
            lsvProduct.FullRowSelect = true;
            lsvProduct.Columns.Add("Mã SP", 80);
            lsvProduct.Columns.Add("Tên sản phẩm", 150);
            lsvProduct.Columns.Add("Giá sản phẩm", 150);
            lsvProduct.Columns.Add("Mã loại", 100);
            lsvProduct.Columns.Add("Số lượng", 100);
            HienThiSanPham();
            HienThiMNCC();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = importBUS.LayMaPNMax() + 1;

            txtImportID.Text = "PN" + b.ToString();
        }
    }
}
