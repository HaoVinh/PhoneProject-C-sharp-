using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileStore.DTO;
using MobileStore.DAO;
using MobileStore.BUS;
using OfficeOpenXml;

namespace MobileStore.GUI
{
    public partial class accountForm : Form
    {
        private employeeBUS emp_BUS = new employeeBUS();
        private accountBUS acc_BUS = new accountBUS();
        RegexPattern regex = new RegexPattern();
        String empID = "";
        String empName = "";
        public accountForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
        }
        void HienThiTaiKhoan()
        {
            lsvAccount.Items.Clear();
            DataTable dt = acc_BUS.LayDSTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvAccount.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void HienThiPermission()
        {
            cmbPermission.Items.Clear();
            cmbPermission.Items.Add(accountDTO.Permission.Employee.ToString());
            cmbPermission.Items.Add(accountDTO.Permission.Manager.ToString());
        }
        void HienThiMaNhanVien()
        {
            DataTable dt = emp_BUS.LayDSNhanvien();
            cmbEmpID.DataSource = dt;
            cmbEmpID.DisplayMember = "EmpID";
            cmbEmpID.ValueMember = "EmpID";
        }

        private void accountForm_Load(object sender, EventArgs e)
        {
            lsvAccount.View = View.Details;
            lsvAccount.GridLines = true;
            lsvAccount.FullRowSelect = true;
            lsvAccount.Columns.Add("Mã tài khoản", 80);
            lsvAccount.Columns.Add("Tên tài khoản", 150);
            lsvAccount.Columns.Add("Mật khẩu", 150);
            lsvAccount.Columns.Add("Mã nhân viên", 100);
            lsvAccount.Columns.Add("Mã quyền", 100);
            HienThiTaiKhoan();
            HienThiMaNhanVien();
            HienThiPermission();
        }
        public void resetData()
        {
            txtAccID.Text = "";
            txtAccName2.Text = "";
            txtPass.Text = "";
            cmbEmpID.SelectedIndex = -1;
            cmbPermission.SelectedIndex = -1;
            HienThiTaiKhoan();
            HienThiMaNhanVien();
            HienThiPermission();
        }
        private void lsvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvAccount.SelectedItems[0];
                txtAccID.Text = selectedItem.SubItems[0].Text;
                txtAccName2.Text = selectedItem.SubItems[1].Text;
                txtPass.Text = selectedItem.SubItems[2].Text;
                cmbEmpID.Text = selectedItem.SubItems[3].Text;
                cmbPermission.Text = selectedItem.SubItems[4].Text;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

            if (/*txtAccID.Text.Trim().Equals("") ||*/ txtAccName2.Text.Trim().Equals("") || txtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string newID = "TK" + (acc_BUS.LayMaTKMax() + 1).ToString();
                string id = newID, username = txtAccName2.Text, pass = txtPass.Text, empid = cmbEmpID.Text;
                accountDTO.Permission permission = (accountDTO.Permission)Enum.Parse(typeof(accountDTO.Permission), cmbPermission.Text);
                accountDTO acc = new accountDTO(id, username, pass, empid, permission);
                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    if (acc_BUS.ThemTaiKhoan(acc))
                    {
                        MessageBox.Show("Thêm thành công");
                        resetData();

                    }

                }

                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }

        }
        //ListViewItem lvi = lsvAccount.Items.Add(acc.AccID);
        //lvi.SubItems.Add(acc.UserName);
        //lvi.SubItems.Add(acc.Password);
        //lvi.SubItems.Add(acc.EmpID);
        //lvi.SubItems.Add(acc.AccountPermission.ToString());
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            String accID = txtAccID.Text;
            if (accID.Length != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công");
                    acc_BUS.XoaNhanVien(accID);
                    HienThiTaiKhoan();
                }

            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
            }
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            if (/*txtAccID.Text.Trim().Equals("") ||*/ txtAccName2.Text.Trim().Equals("") || txtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string id = txtAccID.Text, username = txtAccName2.Text, pass = txtPass.Text, empid = cmbEmpID.Text;
                accountDTO.Permission permission = (accountDTO.Permission)Enum.Parse(typeof(accountDTO.Permission), cmbPermission.Text);
                accountDTO acc = new accountDTO(id, username, pass, empid, permission);
                DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận sửa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //ListViewItem lvi = lsvAccount.Items.Add(acc.AccID);
                    //lvi.SubItems.Add(acc.UserName);
                    //lvi.SubItems.Add(acc.Password);
                    //lvi.SubItems.Add(acc.EmpID);
                    //lvi.SubItems.Add(acc.AccountPermission.ToString());
                    if (acc_BUS.CapNhatNV(acc))
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void accountForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnExportEcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvAccount.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvAccount.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvAccount.Items.Count; i++)
                {
                    for (int j = 0; j < lsvAccount.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvAccount.Items[i].SubItems[j].Text;
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
            int b = acc_BUS.LayMaTKMax() + 1;

            txtAccID.Text = "TK" + b.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetData();
        }
    }
}
