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
    public partial class loadingScreenForm : Form
    {
        public loadingScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 601)
            {
                timer1.Stop(); // Dừng timer trước khi thực hiện các thay đổi khác
                loginForm form = new loginForm();
                form.FormClosed += (s, args) => this.Close(); // Đóng form hiện tại khi form mới được đóng
                form.Show();
                this.Hide();
            }
        }
    }
}
