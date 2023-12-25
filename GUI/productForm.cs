using MobileStore.BUS;
using MobileStore.DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore.GUI
{
    public partial class productForm : Form
    {
        private productBUS product_BUS = new productBUS();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        String empID = "";
        String empName = "";
        public productForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";


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
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void HienThiMTH()
        {
            DataTable dt = product_BUS.LayMaThuongHieu();
            cboProducts_BrandID.DataSource = dt;
            cboProducts_BrandID.DisplayMember = "BrandID";
            cboProducts_BrandID.ValueMember = "BrandID";
        }
        void HienThiML()
        {
            DataTable dt = product_BUS.LayMaLoai();
            cboProducts_CateID.DataSource = dt;
            cboProducts_CateID.DisplayMember = "CategoryID";
            cboProducts_CateID.ValueMember = "CategoryID";
        }
        //void HienThiMNCC()
        //{
        //    DataTable dt = product_BUS.LayMaNCC();
        //    cboProducts_SupID.DataSource = dt;
        //    cboProducts_SupID.DisplayMember = "SupplierID";
        //    cboProducts_SupID.ValueMember = "SupplierID";
        //}

        private void productForm_Load(object sender, EventArgs e)
        {
            lsvProduct.View = View.Details;
            lsvProduct.GridLines = true;
            lsvProduct.FullRowSelect = true;
            lsvProduct.Columns.Add("Mã SP", 80);
            lsvProduct.Columns.Add("Tên sản phẩm", 150);
            lsvProduct.Columns.Add("Giá sản phẩm", 150);
            lsvProduct.Columns.Add("Số lượng", 100);
            lsvProduct.Columns.Add("Mã thương hiệu", 100);
            lsvProduct.Columns.Add("Mã loại", 100);
            HienThiSanPham();
            HienThiMTH();
            HienThiML();
            setCboSearch();
            setCboSearch2();
        }
        public void setCboSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã SP");
            cbxSearch.Items.Add("Tên SP");
        }
        public void setCboSearch2()
        {

            cboSearch2.Items.Add("Sản phẩm < 25 triệu");
            cboSearch2.Items.Add("Sản phẩm > 25 triệu");
        }
        public void setListViewSearchByID(String data)
        {
            lsvProduct.Items.Clear();
            List<productDTO> dt = product_BUS.searchProductByID(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm với mã " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (productDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getproductID());
                lvi.SubItems.Add(cus.getproductName());
                lvi.SubItems.Add(cus.getUnitPrice().ToString());
                lvi.SubItems.Add(cus.getQuantity().ToString());
                lvi.SubItems.Add(cus.getBrandID());
                lvi.SubItems.Add(cus.getCategoryID());

                lsvProduct.Items.Add(lvi);
            }
        }
        public void setListViewSearchByName(String data)
        {
            lsvProduct.Items.Clear();
            List<productDTO> dt = product_BUS.searchProductByName(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm với tên " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (productDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getproductID());
                lvi.SubItems.Add(cus.getproductName());
                lvi.SubItems.Add(cus.getUnitPrice().ToString());
                lvi.SubItems.Add(cus.getQuantity().ToString());
                lvi.SubItems.Add(cus.getBrandID());
                lvi.SubItems.Add(cus.getCategoryID());

                lsvProduct.Items.Add(lvi);
            }
        }
        public void setListViewSearchByNameAndPrice(string data, int minPrice, int maxPrice)
        {
            lsvProduct.Items.Clear();
            List<productDTO> dt = product_BUS.SearchProductByNameAndPrice(data, minPrice, maxPrice);

            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm với tên " + data + " và giá tiền trong khoảng từ " + minPrice + " đến " + maxPrice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (productDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getproductID());
                lvi.SubItems.Add(cus.getproductName());
                lvi.SubItems.Add(cus.getUnitPrice().ToString());
                lvi.SubItems.Add(cus.getQuantity().ToString());
                lvi.SubItems.Add(cus.getBrandID());
                lvi.SubItems.Add(cus.getCategoryID());

                lsvProduct.Items.Add(lvi);
            }
        }
        public void setListViewSearchByNameAndPrice2(string data, int minPrice, int maxPrice)
        {
            lsvProduct.Items.Clear();
            List<productDTO> dt = product_BUS.SearchProductByNameAndPrice2(data, minPrice, maxPrice);

            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm với tên " + data + " và giá tiền trong khoảng từ " + minPrice + " đến " + maxPrice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (productDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getproductID());
                lvi.SubItems.Add(cus.getproductName());
                lvi.SubItems.Add(cus.getUnitPrice().ToString());
                lvi.SubItems.Add(cus.getQuantity().ToString());
                lvi.SubItems.Add(cus.getBrandID());
                lvi.SubItems.Add(cus.getCategoryID());

                lsvProduct.Items.Add(lvi);
            }
        }
        public Boolean checkInput(String productName, String unitPrice, int typeIndex)
        {
            Boolean check = false;
            String checkNum = @"(-)\d{0,9}";
            String checkChar = @"\D";
            Regex rg1 = new Regex(checkNum);
            Regex rg2 = new Regex(checkChar);

            if (productName == "" || unitPrice == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (rg1.IsMatch(unitPrice))
            {
                MessageBox.Show("Đơn giá không được âm");
            }
            else if (rg2.IsMatch(unitPrice))
            {
                MessageBox.Show("Đơn giá phải là số");
            }
            else if (typeIndex == -1)
            {
                MessageBox.Show("Hãy chọn loại sản phẩm");
            }
            else
            {
                check = true;
            }
            return check;
        }
        public void resetData()
        {
            txtProductsID.Text = "";
            txtProductsName.Text = "";
            txtProductsPrice.Text = "";
            txtQuantity.Text = "";
            cboProducts_BrandID.SelectedIndex = -1;
            cboProducts_CateID.SelectedIndex = -1;
            //cboProducts_SupID.SelectedIndex = -1;
            pictureBox3.Image = null;
            HienThiSanPham();
            HienThiMTH();
            HienThiML();
        }

        private void lsvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvProduct.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvProduct.SelectedItems[0];
                txtProductsID.Text = selectedItem.SubItems[0].Text;
                txtProductsName.Text = selectedItem.SubItems[1].Text;
                txtProductsPrice.Text = selectedItem.SubItems[2].Text;
                txtQuantity.Text = selectedItem.SubItems[3].Text;
                cboProducts_BrandID.Text = selectedItem.SubItems[4].Text;
                cboProducts_CateID.Text = selectedItem.SubItems[5].Text;
                //cboProducts_SupID.Text = selectedItem.SubItems[6].Text;

                byte[] imageData = product_BUS.LayHinhSanPham(selectedItem.SubItems[0].Text);
                // Hiển thị hình ảnh lên PictureBox
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox3.Image = Image.FromStream(ms);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductsName.Text.Trim().Equals("") /*|| txtProductsID.Text.Trim().Equals("") */|| txtProductsPrice.Text.Trim().Equals("") || pictureBox3.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string newID = "SP" + (product_BUS.LayMaSPMax() + 1).ToString();
                string id = newID, productname = txtProductsName.Text, brandid = cboProducts_BrandID.Text, cateid = cboProducts_CateID.Text/*, suppid = cboProducts_SupID.Text*/;
                int price, quantity;
                byte[] imageData = ImageToByteArray(pictureBox3.Image);


                if (!int.TryParse(txtProductsPrice.Text, out price) || !int.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("Giá và số lượng phải là số nguyên.");
                    return;
                }

                if (product_BUS.isNameExisted(productname))
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng chọn tên khác.");
                    return;
                }
                productDTO product = new productDTO(id, productname, price, quantity, brandid, cateid/*, suppid*/, imageData);

                if (price < 0 || quantity < 0)
                {
                    MessageBox.Show("Số lượng hoặc giá tiền không là số âm.Vui lòng nhập lại!!");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (product_BUS.ThemSanPham(product))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        resetData();

                    }
                }

                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                    return;
                }
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    String id = txtProductsID.Text;
        //    if (product_BUS.XoaSanPham(id))
        //    {
        //        DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            MessageBox.Show("Xóa sản phẩm thành công!");
        //            resetData();
        //        }

        //    }
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtProductsName.Text.Trim().Equals("") /*|| txtProductsID.Text.Trim().Equals("")*/ || txtProductsPrice.Text.Trim().Equals("") || pictureBox3.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string id = txtProductsID.Text, productname = txtProductsName.Text, brandid = cboProducts_BrandID.Text, cateid = cboProducts_CateID.Text/*, suppid = cboProducts_SupID.Text*/;
                int price, quantity;
                byte[] imageData = ImageToByteArray(pictureBox3.Image);

                if (!int.TryParse(txtProductsPrice.Text, out price) || !int.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("Giá và số lượng phải là số nguyên.");
                    return;
                }

                productDTO product = new productDTO(id, productname, price, quantity, brandid, cateid/*, suppid*/, imageData);
                //if (product_BUS.isNameExisted(productname))
                //{
                //    MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng chọn tên khác.");
                //    return;
                //}

                if (price < 0 || quantity < 0)
                {
                    MessageBox.Show("Số lượng hoặc giá tiền không là số âm.Vui lòng nhập lại!!");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (product_BUS.CapNhatSP(product))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công");
                        resetData();

                    }
                }

                else
                {
                    MessageBox.Show("Sửa sản phẩm không thành công");
                    return;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtSearch.Text;
            if (cbxSearch.SelectedIndex != 0 && string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập thông tin!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = cbxSearch.SelectedIndex;
            if (index == 0)
            {
                HienThiSanPham();
            }
            else if (index == 1)
            {
                setListViewSearchByID(data);
                txtSearch.Text = "";
            }
            else if (index == 2)
            {
                setListViewSearchByName(data);
                txtSearch.Text = "";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvProduct.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvProduct.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvProduct.Items.Count; i++)
                {
                    for (int j = 0; j < lsvProduct.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvProduct.Items[i].SubItems[j].Text;
                    }
                }

                // Lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "output.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                    MessageBox.Show("Xuất dữ liệu thành công!");
                }
            }
        }

        private void ptbProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = product_BUS.LayMaSPMax() + 1;

            txtProductsID.Text = "SP" + b.ToString();
        }

        private void lblImage_Click(object sender, EventArgs e)
        {
            try
            {
                // Chọn ảnh từ PictureBox
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] imageData = ImageToByteArray(pictureBox3.Image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hình: {ex.Message}");
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void DisplayImage(byte[] imageData)
        {

            try
            {
                // Chuyển đổi mảng byte thành đối tượng Image
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);

                    // Hiển thị ảnh lên PictureBox
                    pictureBox3.Image = image;
                    MessageBox.Show("1");

                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("loi" + ex.Message);

            }

        }

        private void cboSearch2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboSearch2.SelectedIndex;
            txtSearch.Enabled = false;
            if (index == 0)
            {
                int defaultMinPrice = 0;
                int defaultMaxPrice = 25000000;
                setListViewSearchByNameAndPrice("", defaultMinPrice, defaultMaxPrice);
            }
            else if (index == 1)
            {
                int defaultMinPrice = 25000001;
                int defaultMaxPrice = 99999999;
                setListViewSearchByNameAndPrice2("", defaultMinPrice, defaultMaxPrice);
            }
        }

        private void ABC_Click(object sender, EventArgs e)
        {

        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {           
            txtSearch.Enabled = true;
            cboSearch2.SelectedIndex = -1;
        }
    }
}
