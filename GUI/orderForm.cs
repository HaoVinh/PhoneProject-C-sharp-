using MobileStore.DTO;
using MobileStore.BUS;
using MobileStore.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using OfficeOpenXml;

namespace MobileStore.GUI
{
    public partial class orderForm : Form
    {
        private orderBUS order_BUS = new orderBUS();
        private employeeBUS emp_BUS = new employeeBUS();
        String getName = "";
        String getId = "";

        public orderForm(String name, String id)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = name + "(" + id + ")";
        }
        void HienThiHoaDon()
        {
            lsvOrder.Items.Clear();
            DataTable dt = order_BUS.LayDSHoaDon();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvOrder.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        public void setCboSearch()
        {
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã hóa đơn");
            cmbTypeSearch.Items.Add("Mã khách hàng");
            cmbTypeSearch.Items.Add("Mã nhân viên");
        }
        public void setListViewSearch(String column, String data)
        {
            lsvOrder.Items.Clear();
            List<orderDTO> dt = order_BUS.searchOrder(column, data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (orderDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getOrderID());
                lvi.SubItems.Add(cus.getCusID());
                lvi.SubItems.Add(cus.getEmpID());
                lvi.SubItems.Add(cus.getDate());

                lsvOrder.Items.Add(lvi);
            }
        }

        private void lsvOrder_ItemActivate(object sender, EventArgs e)
        {
            if (lsvOrder.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvOrder.SelectedItems[0];
                String orderId = lvi.SubItems[0].Text;
                String cusId = lvi.SubItems[1].Text;
                String EmpId = lvi.SubItems[2].Text;
                String date = lvi.SubItems[3].Text;

                ordDetailForm showOrder = new ordDetailForm(getName, getId, orderId, cusId, EmpId, date);
                showOrder.ShowDialog();
            }
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            lsvOrder.View = View.Details;
            lsvOrder.GridLines = true;
            lsvOrder.FullRowSelect = true;
            lsvOrder.Columns.Add("Mã hóa đơn", 80);
            lsvOrder.Columns.Add("Mã khách hàng", 150);
            lsvOrder.Columns.Add("Mã nhân viên", 100);
            lsvOrder.Columns.Add("Ngày lập", 200);
            HienThiHoaDon();
            setCboSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String data = txtContent.Text;
            if (cmbTypeSearch.SelectedIndex != 0 && string.IsNullOrEmpty(txtContent.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập thông tin!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = cmbTypeSearch.SelectedIndex;
            if (index == 0)
            {
                HienThiHoaDon();
            }
            else if (index == 1)
            {
                setListViewSearch("OrderID", data);
                txtContent.Text = "";
            }
            else if (index == 2)
            {
                setListViewSearch("CustomerID", data);
                txtContent.Text = "";
            }
            else if (index == 3)
            {
                setListViewSearch("EmpID", data);
                txtContent.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExportEcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvOrder.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvOrder.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvOrder.Items.Count; i++)
                {
                    for (int j = 0; j < lsvOrder.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvOrder.Items[i].SubItems[j].Text;
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

        private void btnClear_Click(object sender, EventArgs e)
        {  
            txtContent.Text = "";
            cmbTypeSearch.SelectedIndex = -1;
            HienThiHoaDon();
        }
    }
}
