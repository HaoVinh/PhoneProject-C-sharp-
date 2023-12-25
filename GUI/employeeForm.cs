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
using OfficeOpenXml;

namespace MobileStore
{
    public partial class employeeForm : Form
    {
        private employeeBUS emp_BUS = new employeeBUS();
        RegexPattern regex = new RegexPattern();
        String empID = "";
        String empName = "";
        public employeeForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
        }
        void HienThiNhanVien()
        {
            lsvEmployee.Items.Clear();
            DataTable dt = emp_BUS.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvEmployee.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

            }
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            lsvEmployee.View = View.Details;
            lsvEmployee.GridLines = true;
            lsvEmployee.FullRowSelect = true;
            lsvEmployee.Columns.Add("Mã NV", 80);
            lsvEmployee.Columns.Add("Họ Tên", 150);
            lsvEmployee.Columns.Add("Vị trí", 80);
            lsvEmployee.Columns.Add("Số Điện Thoại", 150);
            lsvEmployee.Columns.Add("Địa Chỉ", 200);
            HienThiNhanVien();
            setCboSearch();
        }
        public void setCboSearch()
        {
            cbxSearch.Items.Add("Tất cả");
            cbxSearch.Items.Add("Mã NV");
            cbxSearch.Items.Add("Tên NV");
        }
        public void setListViewSearchByID(String data)
        {
            lsvEmployee.Items.Clear();
            List<employeeDTO> dt = emp_BUS.searchEmployeeByID(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (employeeDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getEmpID());
                lvi.SubItems.Add(cus.getEmpName());
                lvi.SubItems.Add(cus.getPhone());
                lvi.SubItems.Add(cus.getAddress());

                lsvEmployee.Items.Add(lvi);
            }
        }
        public void setListViewSearchByName(String data)
        {
            lsvEmployee.Items.Clear();
            List<employeeDTO> dt = emp_BUS.searchEmployeeByName(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên với tên " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (employeeDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getEmpID());
                lvi.SubItems.Add(cus.getEmpName());
                lvi.SubItems.Add(cus.getPhone());
                lvi.SubItems.Add(cus.getAddress());

                lsvEmployee.Items.Add(lvi);
            }
        }

        public void resetData()
        {
            txtEmpID.Text = "";
            txtEmpName.Text = "";
            txtEmpPosition.Text = "";
            txtEmpPhone.Text = "";
            txtEmpAddress.Text = "";
            HienThiNhanVien();
        }

        private void lsvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvEmployee.SelectedItems[0];
                txtEmpID.Text = selectedItem.SubItems[0].Text;
                txtEmpName.Text = selectedItem.SubItems[1].Text;
                txtEmpPosition.Text = selectedItem.SubItems[2].Text;
                txtEmpPhone.Text = string.Empty;
                txtEmpAddress.Text = string.Empty;

                if (selectedItem.SubItems.Count > 3)
                {
                    txtEmpPhone.Text = selectedItem.SubItems[3].Text;
                }

                if (selectedItem.SubItems.Count > 4)
                {
                    txtEmpAddress.Text = selectedItem.SubItems[4].Text;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text.Trim().Equals("") || txtEmpPhone.Text.Trim().Equals("") || txtEmpAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!regex.checkPhoneNumber(txtEmpPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại(bắt đầu từ 0 và ít nhất 10 số)");
            }
            else
            {
                string newID = "NV" + (emp_BUS.LayMaNVMax() + 1).ToString();
                string id = newID, empname = txtEmpName.Text, position = txtEmpPosition.Text, phone = txtEmpPhone.Text, address = txtEmpAddress.Text;
                employeeDTO emp = new employeeDTO(id, empname, position, phone, address);



                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (emp_BUS.ThemNhanVien(emp))
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
            String id = txtEmpID.Text;
            if (emp_BUS.XoaNhanVien(id))
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
            if ((txtEmpName.Text.Trim().Equals("") || txtEmpPhone.Text.Trim().Equals("") || txtEmpAddress.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!regex.checkPhoneNumber(txtEmpPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại(bắt đầu từ 0 và ít nhất 10 số)");
            }
            else
            {
                string id = txtEmpID.Text, empname = txtEmpName.Text, position = txtEmpPosition.Text, phone = txtEmpPhone.Text, address = txtEmpAddress.Text;
                employeeDTO emp = new employeeDTO(id, empname, position, phone, address);
                if (!id.StartsWith("NV"))
                {
                    MessageBox.Show("Mã nhân viên phải bắt đầu bằng NV");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận sửa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (emp_BUS.CapNhatNV(emp))
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvEmployee.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvEmployee.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvEmployee.Items.Count; i++)
                {
                    for (int j = 0; j < lsvEmployee.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvEmployee.Items[i].SubItems[j].Text;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = emp_BUS.LayMaNVMax() + 1;

            txtEmpID.Text = "NV" + b.ToString();
        }
    }
}
