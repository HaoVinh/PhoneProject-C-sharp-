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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace MobileStore.GUI
{
    public partial class loginForm : Form
    {
        accountBUS acc_BUS = new accountBUS();
        public loginForm()
        {
            InitializeComponent();
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;
            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
            this.KeyPreview = true;
        }

        public String getName()
        {
            String userName = txtUsername.Text;
            String password = txtPassword.Text;
            employeeDTO emp = acc_BUS.getInfoEmp(userName, password);
            return emp.getEmpName();
        }

        public String getId()
        {
            String userName = txtUsername.Text;
            String password = txtPassword.Text;
            employeeDTO emp = acc_BUS.getInfoEmp(userName, password);
            return emp.getEmpID();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUsername.Text;
            String password = txtPassword.Text;

            if (userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!!");
            }
            else
            {
                if (acc_BUS.checkLogin(userName, password).Equals(accountDTO.Permission.Manager))
                {
                    MessageBox.Show("Đăng nhập thành công với tư cách Admin!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    adminLoginForm mainForm = new adminLoginForm(getName(), getId());
                    mainForm.Owner = this;
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if (acc_BUS.checkLogin(userName, password).Equals(accountDTO.Permission.Employee))
                {
                    MessageBox.Show("Đăng nhập thành công với tư cách Nhân Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    employeeLoginForm employeeLoginForm = new employeeLoginForm(getName(), getId());
                    employeeLoginForm.Owner = this;
                    employeeLoginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    txtPassword.Text = "";
                }
            }
        }

        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh "beep"
                btnLogin.PerformClick();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
