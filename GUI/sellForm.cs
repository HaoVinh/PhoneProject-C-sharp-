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

namespace MobileStore.GUI
{
    public partial class sellForm : Form
    {
        private productBUS product_BUS = new productBUS();
        private customerBUS cus_BUS = new customerBUS();
        private orderBUS orderBUS = new orderBUS();
        private ordDetailBUS orde_BUS = new ordDetailBUS();
        List<customerDTO> list = new List<customerDTO>();
        double finalPrice = 0;
        double priceOneRow = 0;
        String cusID = "";
        String empID = "";
        String empName = "";

        public sellForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
            HienThiKH();
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
        void HienThiKH()
        {
            list = cus_BUS.getAllCustomer();
            for (int i = 0; i < list.Count; i++)
            {
                customerDTO cus = list.ElementAt(i);
                String cusName = cus.getCusName() + "(" + cus.getCusID() + ")";
                cmbCusName.Items.Add(cusName);
            }
        }
        public void UpdateQuantity()
        {
            if (lsvProduct.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvProduct.SelectedItems[0];
                int currentIndex = selectedItem.Index;

                if (int.TryParse(selectedItem.SubItems[4].Text, out int currentQuantity) && int.TryParse(txtQuantity.Text, out int quantityToSubtract))
                {
                    if (currentQuantity - quantityToSubtract >= 0)
                    {
                        int newQuantity = currentQuantity - quantityToSubtract;
                        selectedItem.SubItems[4].Text = newQuantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm không đủ, vui lòng nhập lại số lượng.");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi chuyển đổi số lượng sản phẩm.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật số lượng.");
            }
        }
        public Boolean addOrderClick()
        {
            string newID = "HD" + (orderBUS.LayMaHDMax() + 1).ToString();
            Boolean check = false;
            string orderDate = dtpOrder.Value.ToString("MM/dd/yyyy");
            orderDTO order = new orderDTO(txtOrderID.Text
                , cusID
                , empID
                , orderDate);

            if (orderBUS.ThemHoaDon(order))
            {
                check = true;
            }
            return check;
        }
        public void AddOrUpdateOrderDetail()
        {

            string orderID = txtOrderID.Text;

            foreach (ListViewItem item in lsvOrder.Items)
            {
                string productID = item.SubItems[0].Text;
                int quantity = int.Parse(item.SubItems[3].Text);
                int price = int.Parse(item.SubItems[5].Text);

                bool orderDetailExists = orde_BUS.checkOrderDetail(orderID, productID);

                if (!orderDetailExists)
                {
                    orderDetailDTO orderDetail = new orderDetailDTO(orderID, productID, price, quantity);
                    bool result = orde_BUS.ThemChiTietHoaDon(orderDetail);
                }
                else
                {
                    orderDetailDTO orderDetail = new orderDetailDTO(orderID, productID, price, quantity);
                    bool result = orde_BUS.CapNhatChiTietHD(orderDetail);
                }
            }
        }
        public void updateProductQuantity()
        {
            List<orderDetailDTO> list = orde_BUS.getOrderDetail(txtOrderID.Text);

            for (int i = 0; i < list.Count; i++)
            {
                orderDetailDTO cthd = list[i];
                Boolean n = product_BUS.updateQuantityProduct(cthd.getProductID(), cthd.getQuantity());
            }
        }
        public Boolean checkQuantity(String quantity)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            System.Text.RegularExpressions.Regex rg1 = new System.Text.RegularExpressions.Regex(checkNum);
            System.Text.RegularExpressions.Regex rg2 = new System.Text.RegularExpressions.Regex(checkChar);
            if (rg1.IsMatch(quantity) == false && rg2.IsMatch(quantity) == false && quantity.Equals("0") == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Sai định dạng , vui lòng nhập lại số lượng!!");
                txtQuantity.Text = "";
            }
            return check;
        }
        public Boolean checkOrderID(String orderID)
        {
            Boolean check = false;
            String checkOrder = @"(HD)\d{0,9}";
            System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(checkOrder);
            if (rg.IsMatch(orderID) && orderBUS.CheckOrder(orderID) == false && orderID.Equals("") == false)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không đúng cú pháp hoặc bị trùng , vui lòng nhập lại!!");
            }
            return check;
        }

        private void lsvProduct_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem selectedProduct = e.Item;
                txtProductId.Text = selectedProduct.SubItems[0].Text;
                txtProductName.Text = selectedProduct.SubItems[1].Text;
                txtCateId.Text = selectedProduct.SubItems[3].Text;
                txtPrice.Text = selectedProduct.SubItems[2].Text;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text) || txtQuantity.Text.Equals("..."))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                return;
            }
            else if (checkQuantity(txtQuantity.Text))
            {
                txtEmpName.Text = txtAccName.Text;
                dtpOrder.Value = DateTime.Now;

                // Set dữ liệu cho bảng Order
                int unitPrice = int.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                // Kiểm tra số lượng sản phẩm còn lại
                int currentQuantity = int.Parse(lsvProduct.SelectedItems[0].SubItems[4].Text);
                if (currentQuantity - quantity < 0)
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ, vui lòng nhập lại số lượng.");
                    return;
                }

                // Kiểm tra sản phẩm có tồn tại hay không
                string productID = lsvProduct.SelectedItems[0].SubItems[0].Text;
                if (!product_BUS.CheckProductID(productID))
                {
                    MessageBox.Show("Sản phẩm không tồn tại, vui lòng chọn sản phẩm khác.");
                    return;
                }

                // Kiểm tra số lượng sản phẩm nhập vào
                if (quantity > currentQuantity)
                {
                    MessageBox.Show("Số lượng sản phẩm nhập vào vượt quá số lượng sản phẩm hiện tại.");
                    return;
                }

                // Kiểm tra và cập nhật giá trị của các trường
                if (string.IsNullOrEmpty(txtProductId.Text) || string.IsNullOrEmpty(txtCateId.Text) ||
                    string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtQuantity.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm");
                    return;
                }

                // Thêm cột vào ListView nếu chưa được thêm
                if (lsvOrder.Columns.Count == 0)
                {
                    lsvOrder.Columns.Add("Mã");
                    lsvOrder.Columns.Add("Loại");
                    lsvOrder.Columns.Add("Tên");
                    lsvOrder.Columns.Add("Số lượng");
                    lsvOrder.Columns.Add("Đơn giá");
                    lsvOrder.Columns.Add("Thành tiền");
                }
                double discountPercentage = double.Parse(cboDiscount.SelectedItem.ToString().TrimEnd('%')) / 100.0;
                double discountedPrice = unitPrice * quantity * (1 - discountPercentage);
                double firstPrice = unitPrice * quantity;
                priceOneRow += firstPrice;
                // Thêm dữ liệu vào ListView
                ListViewItem item = new ListViewItem(txtProductId.Text);
                item.SubItems.Add(txtCateId.Text);
                item.SubItems.Add(txtProductName.Text);
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add(txtPrice.Text);
                item.SubItems.Add(discountedPrice.ToString());

                // Kiểm tra số lượng sản phẩm nhập vào
                if (quantity == 0)
                {
                    // Không hiển thị sản phẩm
                    lsvOrder.Items.Remove(item);
                }
                else
                {
                    // Hiển thị sản phẩm
                    lsvOrder.Items.Add(item);
                }

                // Đảm bảo rằng ListView hiển thị đúng cách
                lsvOrder.View = View.Details;
                lsvOrder.GridLines = true;
                lsvOrder.FullRowSelect = true;
                lsvOrder.Columns[0].Width = 200;



                //// Tính tổng tiền
                finalPrice += discountedPrice;
                txtPriceAll.Text = finalPrice.ToString();
                txtPricePro.Text = priceOneRow.ToString();


                // Cập nhật lại bảng sản phẩm
                UpdateQuantity();
            }
        }
        private void ResetInputFields()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtCateId.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lsvProduct.SelectedItems.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            txtPriceAll.Text = "";
            txtPricePro.Text = "";
            dtpOrder.Value = DateTime.Now;
            finalPrice = 0;
            priceOneRow = 0;
            lsvOrder.Items.Clear();
            HienThiSanPham();
        }



        private void btnPay_Click(object sender, EventArgs e)
        {
            if (checkOrderID(txtOrderID.Text) && !string.IsNullOrEmpty(txtOrderID.Text))
            {
                customerDTO ctm = list.ElementAt(cmbCusName.SelectedIndex);
                cusID = ctm.getCusID();
                if (addOrderClick())
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                AddOrUpdateOrderDetail();
                updateProductQuantity();
                HienThiSanPham();

            }
            else
            {
                MessageBox.Show("Thanh toán không thành công. Vui lòng kiểm tra lại thông tin đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //txtPriceAll.Text = "";
        //txtPricePro.Text = "";
        //txtDate.Text = "";
        //finalPrice = 0;
        //lsvOrder.Items.Clear();
        //lsvProduct.Items.Clear();
        private void sellForm_Load(object sender, EventArgs e)
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

            cboDiscount.Items.AddRange(new object[] { "0%", "5%", "10%", "15%", "20%" });
            cboDiscount.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int b = orderBUS.LayMaHDMax() + 1;

            txtOrderID.Text = "HD" + b.ToString();
        }

        private void cboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            double discountPercentage = double.Parse(cboDiscount.SelectedItem.ToString().TrimEnd('%')) / 100.0;

            // Cập nhật lại tổng tiền cho các sản phẩm trong đơn hàng
            foreach (ListViewItem item in lsvOrder.Items)
            {
                double itemPrice = double.Parse(item.SubItems[4].Text);
                double discountedItemPrice = itemPrice * (1 - discountPercentage);
                item.SubItems[5].Text = discountedItemPrice.ToString();
            }

            // Tính lại tổng tiền dựa trên giá đã giảm của từng sản phẩm
            double newTotalPrice = lsvOrder.Items.Cast<ListViewItem>()
                                                .Sum(item => double.Parse(item.SubItems[5].Text));

            // Hiển thị giá sau khi giảm
            txtPriceAll.Text = newTotalPrice.ToString();
        }
    }

}
