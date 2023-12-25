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
    public partial class adminLoginForm : Form
    {
        String getName = "";
        String getid = "";
        private bool isConfirmed = false;
        public adminLoginForm(String name, String id)
        {
            InitializeComponent();
            IsMdiContainer = true;
            getName = name;
            getid = id;
            txtAccName.Text = name + "(" + id + ")";

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void txtAccName_Click(object sender, EventArgs e)
        {

        }

        private void picLogOut_Click(object sender, EventArgs e)
        {


        }

        private void txtSellForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new sellForm(getName, getid));
        }

        private void txtImportPro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new importProForm(getName, getid));
        }

        private void txtOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new orderForm(getName, getid));
        }

        private void txtImport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new importForm(getName, getid));
        }

        private void txtEmp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new employeeForm(getName, getid));
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new categoryForm(getName, getid));
        }

        private void txtCake_Click(object sender, EventArgs e)
        {
            OpenChildForm(new productForm(getName, getid));
        }

        private void txtSupp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new supplierForm(getName, getid));
        }

        private void txtAcc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new accountForm(getName, getid));
        }

        private void txtCus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new customerForm(getName, getid));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new brandForm(getName, getid));
        }

        private void adminLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        private void txtStatic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new reportForm(getName, getid));
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }
    }
}
