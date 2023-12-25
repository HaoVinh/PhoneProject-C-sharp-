using Microsoft.Office.Interop.Excel;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore.GUI
{
    public partial class reportForm : Form
    {

        private reportBUS report_BUS = new reportBUS();
        String empID = "";
        String empName = "";
        public reportForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
            setDefaultValue();
            setCboSearch();
            setCboIDateFormat();
            setCboSellSearch();
            setCboSellDateFormat();

        }
        private void setDefaultValue()
        {
            dtpEnd.Value = DateTime.Now;
            txtTotalEmployee.Text = report_BUS.countEmployee().ToString();
            txtTotalCustomer.Text = report_BUS.countCustomer().ToString();
            txtTotalProduct.Text = report_BUS.countProduct().ToString();
            txtTotalOrder.Text = report_BUS.countOrder().ToString();
            txtTotalSupplier.Text = report_BUS.countSupplier().ToString();
            txtTotalImport.Text = report_BUS.countImport().ToString();

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 0)
            //{
            //    //end time is now
            //    dtpEnd.Value = DateTime.Now;
            //    string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            //    string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            //    string field = "Product.ProductName";
            //    string data = "";
            //    reportImportTable(start_time, end_time, field, data);

            //}
            //else if (tabControl1.SelectedIndex == 1)
            //{
            //    //end time is now
            //    dtpEnd.Value = DateTime.Now;
            //    string start_time = dtpStartSell.Value.ToString("yyyy-MM-dd");
            //    string end_time = dtpEndSell.Value.ToString("yyyy-MM-dd");
            //    string field = "Product.ProductName";
            //    string data = "";
            //    reportSellTable(start_time, end_time, field, data);
            //}
            //else if (tabControl1.SelectedIndex == 2)
            //{
            //    txtTotalEmployee.Text = report_BUS.countEmployee().ToString();
            //    txtTotalCustomer.Text = report_BUS.countCustomer().ToString();
            //    txtTotalProduct.Text = report_BUS.countProduct().ToString();
            //    txtTotalImport.Text = report_BUS.countOrder().ToString();
            //    txtTotalSupplier.Text = report_BUS.countSupplier().ToString();
            //    txtTotalImport.Text = report_BUS.countImport().ToString();
            //}
        }
        #region ImportReport
        public void setCboSearch()
        {
            cbxSearch.Items.Add("Mã sản phẩm");
            cbxSearch.Items.Add("Tên sản phẩm");

        }

        public void setCboIDateFormat()
        {
            ImportDateFormat.Items.Add("Ngày");
            ImportDateFormat.Items.Add("Tháng");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = cbxSearch.SelectedIndex;
            if(searchValue.Text.Trim().Equals("") )
            {
                MessageBox.Show("Vui lòng nhập thông tin!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string field = "Product.ProductID";
            string data = "";
            if (index == 0)
            {
                field = "Product.ProductID";
                data = searchValue.Text;

            }
            else if (index == 1)
            {
                field = "Product.ProductName";
                data = searchValue.Text;
            }
            //set start time end time with format 
            int formatIndex = ImportDateFormat.SelectedIndex;
            string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            string format = "";
            if (formatIndex == 1)
            {
                format = "Y-m";
            }

            reportImportTable(start_time, end_time, field, data, format);
        }
        private void reportImportTable(string start_time, string end_time, string field, string data, string format = "")
        {
            tableImportReport.Rows.Clear();
            tableImportReport.ColumnCount = 7;
            tableImportReport.Columns[0].Name = "Mã sản phẩm";
            tableImportReport.Columns[1].Name = "Tên sản phẩm";
            tableImportReport.Columns[2].Name = "Loại sản phẩm";
            tableImportReport.Columns[3].Name = "Nhà cung cấp";
            tableImportReport.Columns[4].Name = "Số lượng";
            tableImportReport.Columns[5].Name = "Tổng tiền";
            tableImportReport.Columns[6].Name = "Thời gian";
            List<reportImportDTO> list = report_BUS.reportImport(start_time, end_time, field, data, format);
            foreach (reportImportDTO item in list)
            {
                tableImportReport.Rows.Add(item.ProductId, item.ProductName, item.ProductType, item.Supplier, item.Quantity.ToString(), item.TotalPrice.ToString(), item.Date);
            }

        }

        private void exportExcel_Click(object sender, EventArgs e)
        {

            using (ExcelPackage excelPackage = new ExcelPackage())
            {

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");


                for (int j = 0; j < tableImportReport.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = tableImportReport.Columns[j].HeaderText;
                }


                for (int i = 0; i < tableImportReport.Rows.Count; i++)
                {
                    for (int j = 0; j < tableImportReport.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = tableImportReport.Rows[i].Cells[j].Value.ToString();
                    }
                }


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
        private void btnRefesh_Click(object sender, EventArgs e)
        {

            searchValue.Text = "";
            cbxSearch.SelectedIndex = -1;
            ImportDateFormat.SelectedIndex = -1;


            dtpStart.Value = new DateTime(2022, 1, 1);
            dtpEnd.Value = DateTime.Now;


            string field = "Product.ProductName";
            string data = "";
            string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            reportImportTable(start_time, end_time, field, data);
        }
        #endregion
        #region SellReport
        private void reportSellTable(string start_time, string end_time, string field, string data, string date_format = "")
        {
            tableSellReport.Rows.Clear();
            tableSellReport.ColumnCount = 7;
            tableSellReport.Columns[0].Name = "Mã sản phẩm";
            tableSellReport.Columns[1].Name = "Tên sản phẩm";
            tableSellReport.Columns[2].Name = "Loại sản phẩm";
            tableSellReport.Columns[3].Name = "Khách hàng";
            tableSellReport.Columns[4].Name = "Số lượng";
            tableSellReport.Columns[5].Name = "Tổng tiền";
            tableSellReport.Columns[6].Name = "Thời gian";
            List<reportSellDTO> list = report_BUS.reportSell(start_time, end_time, field, data, date_format);
            foreach (reportSellDTO item in list)
            {
                tableSellReport.Rows.Add(item.ProductId, item.ProductName, item.ProductType, item.CustomerName, item.Quantity.ToString(), item.TotalPrice.ToString(), item.Date);
            }
        }

        public void setCboSellSearch()
        {
            cbxSellSearch.Items.Add("Mã sản phẩm");
            cbxSellSearch.Items.Add("Tên sản phẩm");
        }

        public void setCboSellDateFormat()
        {
            sellCbxDateFormat.Items.Add("Ngày");
            sellCbxDateFormat.Items.Add("Tháng");
        }
        private void btnSellSearch_Click(object sender, EventArgs e)
        {
            int index = cbxSellSearch.SelectedIndex;
            string field = "Product.ProductID";
            string data = "";
            if (index == 0)
            {
                field = "Product.ProductID";
                data = sellSearch.Text;

            }
            else if (index == 1)
            {
                field = "Product.ProductName";
                data = sellSearch.Text;
            }

            string start_time = dtpStartSell.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEndSell.Value.ToString("yyyy-MM-dd");
            int formatIndex = sellCbxDateFormat.SelectedIndex;
            string format = "";
            if (formatIndex == 1)
            {
                format = "Y-m";
            }
            reportSellTable(start_time, end_time, field, data, format);
        }

        private void exportExcelSell_Click(object sender, EventArgs e)
        {

            using (ExcelPackage excelPackage = new ExcelPackage())
            {

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int j = 0; j < tableSellReport.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = tableSellReport.Columns[j].HeaderText;
                }

                for (int i = 0; i < tableSellReport.Rows.Count; i++)
                {
                    for (int j = 0; j < tableSellReport.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = tableSellReport.Rows[i].Cells[j].Value.ToString();
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
        private void btnSellRefesh_Click(object sender, EventArgs e)
        {
            sellSearch.Text = "";
            cbxSellSearch.SelectedIndex = -1;
            sellCbxDateFormat.SelectedIndex = -1;


            dtpStartSell.Value = new DateTime(2022, 1, 1);
            dtpEndSell.Value = DateTime.Now;


            string field = "Product.ProductName";
            string data = "";
            string start_time = dtpStartSell.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEndSell.Value.ToString("yyyy-MM-dd");
            reportSellTable(start_time, end_time, field, data);
        }
        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {

            //end time is now
            dtpEnd.Value = DateTime.Now;
            string start_time = dtpStart.Value.ToString("yyyy-MM-dd");
            string end_time = dtpEnd.Value.ToString("yyyy-MM-dd");
            string field = "Product.ProductName";
            string data = "";
            reportImportTable(start_time, end_time, field, data);

            reportSellTable(start_time, end_time, field, data);


            txtTotalEmployee.Text = report_BUS.countEmployee().ToString();
            txtTotalCustomer.Text = report_BUS.countCustomer().ToString();
            txtTotalProduct.Text = report_BUS.countProduct().ToString();
            txtTotalOrder.Text = report_BUS.countOrder().ToString();
            txtTotalSupplier.Text = report_BUS.countSupplier().ToString();
            txtTotalImport.Text = report_BUS.countImport().ToString();

        }
    }
}
