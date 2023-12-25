using OfficeOpenXml;
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
    public partial class supplierForm : Form
    {
        private supplierBUS sup_BUS = new supplierBUS();
        RegexPattern regex = new RegexPattern();
        String empID = "";
        String empName = "";
        public supplierForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";

        }
        void HienThiNhaCC()
        {
            lsvSupplier.Items.Clear();
            DataTable dt = sup_BUS.LayDSNhaCC();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvSupplier.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

            }
        }

        private void supplierForm_Load(object sender, EventArgs e)
        {
            lsvSupplier.View = View.Details;
            lsvSupplier.GridLines = true;
            lsvSupplier.FullRowSelect = true;
            lsvSupplier.Columns.Add("Mã Nhà CC", 80);
            lsvSupplier.Columns.Add("Tên nhà cung cấp", 150);
            lsvSupplier.Columns.Add("Địa Chỉ", 200);
            lsvSupplier.Columns.Add("Số Điện Thoại", 150);
            lsvSupplier.Columns.Add("Liên hệ", 80);
            HienThiNhaCC();
            setCboSearch();
        }
        public void setCboSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã NCC");
            cbxSearch.Items.Add("Tên NCC");
        }
        public void setListViewSearchByID(String data)
        {
            lsvSupplier.Items.Clear();
            List<supplierDTO> dt = sup_BUS.searchSupplierByID(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp với mã " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (supplierDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getSuppID());
                lvi.SubItems.Add(cus.getSuppName());
                lvi.SubItems.Add(cus.getAddress());
                lvi.SubItems.Add(cus.getPhone());
                lvi.SubItems.Add(cus.getContactPerson());

                lsvSupplier.Items.Add(lvi);
            }
        }
        public void setListViewSearchByName(String data)
        {
            lsvSupplier.Items.Clear();
            List<supplierDTO> dt = sup_BUS.searchSupplierByName(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp với tên " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (supplierDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getSuppID());
                lvi.SubItems.Add(cus.getSuppName());
                lvi.SubItems.Add(cus.getAddress());
                lvi.SubItems.Add(cus.getPhone());
                lvi.SubItems.Add(cus.getContactPerson());

                lsvSupplier.Items.Add(lvi);
            }
        }
        public void resetData()
        {
            txtSupID.Text = "";
            txtSupName.Text = "";
            txtSupAddress.Text = "";
            txtSupPhone.Text = "";
            txtSupContact.Text = "";
            HienThiNhaCC();
        }
        private void lsvSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSupplier.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvSupplier.SelectedItems[0];
                txtSupID.Text = selectedItem.SubItems[0].Text;
                txtSupName.Text = selectedItem.SubItems[1].Text;
                txtSupAddress.Text = selectedItem.SubItems[2].Text;
                txtSupPhone.Text = selectedItem.SubItems[3].Text;
                txtSupContact.Text = selectedItem.SubItems[4].Text;


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtSupName.Text.Trim().Equals("") || txtSupPhone.Text.Trim().Equals("") /*|| txtSupID.Text.Trim().Equals("")*/ || txtSupAddress.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!regex.checkPhoneNumber(txtSupPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại(bắt đầu từ 0 và ít nhất 10 số)");
            }
            else
            {
                string newID = "NCC" + (sup_BUS.LayMaNCCMax() + 1).ToString();
                string id = newID, supname = txtSupName.Text, address = txtSupAddress.Text, phone = txtSupPhone.Text, contact = txtSupContact.Text;
                supplierDTO sup = new supplierDTO(id, supname, address, phone, contact);
                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (sup_BUS.ThemNhaCC(sup))
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((txtSupName.Text.Trim().Equals("") || txtSupPhone.Text.Trim().Equals("") || txtSupID.Text.Trim().Equals("") || txtSupAddress.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!regex.checkPhoneNumber(txtSupPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại");
            }
            else
            {
                string id = txtSupID.Text, supname = txtSupName.Text, address = txtSupAddress.Text, phone = txtSupPhone.Text, contact = txtSupContact.Text;
                supplierDTO sup = new supplierDTO(id, supname, address, phone, contact);
                DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận sửa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (sup_BUS.CapNhatNhaCC(sup))
                    {
                        MessageBox.Show("Sửa thành công");
                        resetData();

                    }

                }

                else
                {
                    MessageBox.Show("Sửa không thành công");
                    return;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtSupID.Text;
            if (sup_BUS.XoaNhaCC(id))
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
                HienThiNhaCC();
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



        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvSupplier.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvSupplier.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvSupplier.Items.Count; i++)
                {
                    for (int j = 0; j < lsvSupplier.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvSupplier.Items[i].SubItems[j].Text;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = sup_BUS.LayMaNCCMax() + 1;

            txtSupID.Text = "NCC" + b.ToString();
        }
    }
}

