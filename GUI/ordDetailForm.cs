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
using System.Xml.Linq;
using System.Globalization;
using System.Drawing.Printing;

namespace MobileStore.GUI
{
    public partial class ordDetailForm : Form
    {
        String getName = "";
        String getId = "";
        private ordDetailBUS od_BUS = new ordDetailBUS();
        private orderInfoBUS orderInfo_BUS = new orderInfoBUS();
        private PrintDocument printDocument = new PrintDocument();

        public ordDetailForm(String name, String id, String orderID, String cusID, String empID, String date)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = name + "(" + id + ")";
            txtOrderId.Text = orderID;
            txtCus.Text = cusID;
            txtEmp.Text = empID;
            txtDate.Text = date;

            HienThiCTHD();
            UpdateTotalAmountLabel();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            String orderID = txtOrderId.Text;
            String cusID = txtCus.Text;
            String empID = txtEmp.Text;
            String date = txtDate.Text;

            List<orderInfoDTO> orderDetails = orderInfo_BUS.getAllOrderInfor(orderID, cusID, empID);


            Brush brush = new SolidBrush(Color.Black);
            String invoiceTitle = "CHI TIẾT HÓA ĐƠN";
            int textWidth = TextRenderer.MeasureText(invoiceTitle, new Font("Arial", 16)).Width;
            int centerX = (e.PageBounds.Width - textWidth) / 2;


            //Image companyLogo = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\Alpha Mobile-logos.jpeg");
            //e.Graphics.DrawImage(companyLogo, new Rectangle(10, 10, 50, 50));

            Image phoneIcon = Image.FromFile("C:\\Users\\Dell\\Downloads\\MobileStore\\img\\phone.png");
            e.Graphics.DrawImage(phoneIcon, new Rectangle(600, 10, 50, 50));

            e.Graphics.DrawString(invoiceTitle, new Font("Arial", 18), brush, new Point(centerX, 10));




            //e.Graphics.DrawString("Hotline: 0987654321", new Font("Arial", 12), brush, new Point(40, 70));


            //e.Graphics.DrawString("Website: https://mobilestore.com", new Font("Arial", 12), brush, new Point(10, 90));


            e.Graphics.DrawString("Mã hóa đơn: ", new Font("Arial", 12), brush, new Point(10, 30));
            e.Graphics.DrawString(orderID, new Font("Arial", 12), brush, new Point(120, 30));

            e.Graphics.DrawString("Mã khách hàng: ", new Font("Arial", 12), brush, new Point(10, 50));
            e.Graphics.DrawString(cusID, new Font("Arial", 12), brush, new Point(140, 50));

            e.Graphics.DrawString("Mã nhân viên: ", new Font("Arial", 12), brush, new Point(10, 70));
            e.Graphics.DrawString(empID, new Font("Arial", 12), brush, new Point(120, 70));

            e.Graphics.DrawString("Ngày lập:", new Font("Arial", 12), brush, new Point(10, 90));
            e.Graphics.DrawString(date, new Font("Arial", 12), brush, new Point(120, 90));


            e.Graphics.DrawString("Mã sản phẩm", new Font("Arial", 12), brush, new Point(10, 130));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Arial", 12), brush, new Point(130, 130));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 12), brush, new Point(300, 130));
            e.Graphics.DrawString("Giá đơn vị", new Font("Arial", 12), brush, new Point(500, 130));

            int rowHeight = 30;
            int y = 150;
            double totalAmount = 0;
            foreach (orderInfoDTO detail in orderDetails)
            {
                String productID = detail.getProductID();
                String productName = detail.getProductName();
                int quantity = detail.getQuantity();
                double unitPrice = detail.getPrice();
                totalAmount += unitPrice * quantity;

                e.Graphics.DrawString(productID, new Font("Arial", 12), brush, new Point(10, y));
                e.Graphics.DrawString(productName, new Font("Arial", 12), brush, new Point(130, y));
                e.Graphics.DrawString(quantity.ToString(), new Font("Arial", 12), brush, new Point(320, y));
                e.Graphics.DrawString(unitPrice.ToString() + " VND", new Font("Arial", 12), brush, new Point(500, y));

                y += rowHeight;
            }


            e.Graphics.DrawString("Thành tiền:", new Font("Arial", 12), brush, new Point(10, 250));
            e.Graphics.DrawString(totalAmount.ToString() + " VND", new Font("Arial", 12), brush, new Point(120, 250));


            MessageBox.Show("In hóa đơn thành công!!");
        }
        public void HienThiCTHD()
        {
            List<orderInfoDTO> list = orderInfo_BUS.getAllOrderInfor(txtOrderId.Text, txtCus.Text, txtEmp.Text);
            tableOrderDetail.ColumnCount = 5;
            tableOrderDetail.Columns[0].Name = "Mã sản phẩm";
            tableOrderDetail.Columns[1].Name = "Tên sản phẩm";
            tableOrderDetail.Columns[2].Name = "Đơn giá";
            tableOrderDetail.Columns[3].Name = "Số lượng";
            tableOrderDetail.Columns[4].Name = "Thành tiền";

            for (int i = 0; i < list.Count; i++)
            {
                orderInfoDTO infor = list[i];
                tableOrderDetail.Rows.Add(
                    infor.getProductID(),
                    infor.getProductName(),
                    infor.getUnitPrice(),
                    infor.getQuantity(),
                    infor.getPrice()
                );
            }
        }
        private void UpdateTotalAmountLabel()
        {
            int totalAmount = CalculateTotalAmount();
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTotalAmount.Text = $" {totalAmount.ToString("C", culture)}";
        }
        private int CalculateTotalAmount()
        {
            int totalAmount = 0;

            foreach (DataGridViewRow row in tableOrderDetail.Rows)
            {
                // Assuming that the total amount is in the last column (index 4)
                totalAmount += Convert.ToInt32(row.Cells[4].Value);
            }

            return totalAmount;
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ordDetailForm_Load(object sender, EventArgs e)
        {
            printDocument.PrintPage += printDocument_PrintPage;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            // Lấy ngày tháng từ control
            DateTime date = DateTime.Parse(txtDate.Text);

            // Hiển thị ngày tháng
            txtDate.Text = date.ToString("MM/dd/yyyy");
        }

        private void ABC_Click(object sender, EventArgs e)
        {

        }
    }
}
