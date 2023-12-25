using MobileStore.DTO;
using MobileStore.DAO;
using MobileStore.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace MobileStore.GUI
{
    public partial class customerForm : Form
    {
        private customerBUS cus_BUS = new customerBUS();
        RegexPattern regex = new RegexPattern();
        String empID = "";
        String empName = "";
        public customerForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
        }
        void HienThiNhanVien()
        {
            lsvCustomer.Items.Clear();
            DataTable dt = cus_BUS.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvCustomer.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            lsvCustomer.View = View.Details;
            lsvCustomer.GridLines = true;
            lsvCustomer.FullRowSelect = true;
            lsvCustomer.Columns.Add("Mã NV", 80);
            lsvCustomer.Columns.Add("Họ và Tên", 150);
            lsvCustomer.Columns.Add("Số Điện Thoại", 100);
            lsvCustomer.Columns.Add("Địa Chỉ", 200);
            HienThiNhanVien();
            setCboSearch();
        }
        public void setCboSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã KH");
            cbxSearch.Items.Add("Tên KH");
        }
        public void setListViewSearchByID(String data)
        {
            lsvCustomer.Items.Clear();
            List<customerDTO> dt = cus_BUS.searchCustomerByID(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng với mã " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (customerDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getCusID());
                lvi.SubItems.Add(cus.getCusName());
                lvi.SubItems.Add(cus.getPhone());
                lvi.SubItems.Add(cus.getAddress());

                lsvCustomer.Items.Add(lvi);
            }
        }
        public void setListViewSearchByName(String data)
        {
            lsvCustomer.Items.Clear();
            List<customerDTO> dt = cus_BUS.searchCustomerByName(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng với tên " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (customerDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getCusID());
                lvi.SubItems.Add(cus.getCusName());
                lvi.SubItems.Add(cus.getPhone());
                lvi.SubItems.Add(cus.getAddress());

                lsvCustomer.Items.Add(lvi);
            }
        }

        public void resetData()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtCusPhone.Text = "";
            txtCusAddress.Text = "";
            HienThiNhanVien();
        }

        private void lsvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCustomer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvCustomer.SelectedItems[0];
                txtCusID.Text = selectedItem.SubItems[0].Text;
                txtCusName.Text = selectedItem.SubItems[1].Text;
                txtCusPhone.Text = string.Empty;
                txtCusAddress.Text = string.Empty;

                if (selectedItem.SubItems.Count > 2)
                {
                    txtCusPhone.Text = selectedItem.SubItems[2].Text;
                }

                if (selectedItem.SubItems.Count > 3)
                {
                    txtCusAddress.Text = selectedItem.SubItems[3].Text;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtCusName.Text.Trim().Equals("") || txtCusPhone.Text.Trim().Equals("") || txtCusAddress.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!regex.checkPhoneNumber(txtCusPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại(bắt đầu từ 0 và ít nhất 10 số)");
            }
            else
            {
                string newID = "KH" + (cus_BUS.LayMaKHMax() + 1).ToString();
                string id = newID, cusname = txtCusName.Text, phone = txtCusPhone.Text, address = txtCusAddress.Text;
                customerDTO cus = new customerDTO(id, cusname, phone, address);
                if (!id.StartsWith("KH"))
                {
                    MessageBox.Show("Mã khách hàng phải bắt đầu bằng 'KH'.");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    if (cus_BUS.ThemNhanVien(cus))
                    {
                        MessageBox.Show("Thêm thành công");
                        resetData();

                    }
                }

                else
                {
                    MessageBox.Show("Thêm không thành công");
                    return;
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtCusID.Text;
            if (cus_BUS.XoaNhanVien(id))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    resetData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((txtCusName.Text.Trim().Equals("") || txtCusPhone.Text.Trim().Equals("") || txtCusAddress.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!regex.checkPhoneNumber(txtCusPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại(bắt đầu từ 0 và ít nhất 10 số)");
            }
            else
            {
                string id = txtCusID.Text, cusname = txtCusName.Text, phone = txtCusPhone.Text, address = txtCusAddress.Text;
                customerDTO cus = new customerDTO(id, cusname, phone, address);
                if (cus_BUS.CapNhatNV(cus))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Sửa thành công");
                        resetData();
                    }
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
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
                HienThiNhanVien();
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

        private void customerForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvCustomer.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvCustomer.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvCustomer.Items.Count; i++)
                {
                    for (int j = 0; j < lsvCustomer.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvCustomer.Items[i].SubItems[j].Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int b = cus_BUS.LayMaKHMax() + 1;

            txtCusID.Text = "KH" + b.ToString();
        }
    }
}
