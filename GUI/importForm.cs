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
using System.Xml.Linq;
using OfficeOpenXml;

namespace MobileStore.GUI
{
    public partial class importForm : Form
    {
        private importBUS imp_BUS = new importBUS();
        String getName = "";
        String getId = "";
        public importForm(String name, String id)
        {
            InitializeComponent();
            getId = id;
            getName = name;
            txtAccName.Text = name + "(" + id + ")";

        }
        void HienThiNhapHang()
        {
            lsvImport.Items.Clear();
            DataTable dt = imp_BUS.LayDSNhapHang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvImport.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        public void setCboSearch()
        {
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã đơn nhập");
            cmbTypeSearch.Items.Add("Mã nhà cung cấp");
            cmbTypeSearch.Items.Add("Mã nhân viên");
        }
        public void setListViewSearch(String column, String data)
        {
            lsvImport.Items.Clear();
            List<importDTO> dt = imp_BUS.searchImport(column, data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (importDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getImportID());
                lvi.SubItems.Add(cus.getSuppID());
                lvi.SubItems.Add(cus.getDate());
                lvi.SubItems.Add(cus.getEmpID());

                lsvImport.Items.Add(lvi);
            }
        }
        private void importForm_Load(object sender, EventArgs e)
        {
            lsvImport.View = View.Details;
            lsvImport.GridLines = true;
            lsvImport.FullRowSelect = true;
            lsvImport.Columns.Add("Mã đơn nhập", 80);
            lsvImport.Columns.Add("Mã nhà cung cấp", 150);
            lsvImport.Columns.Add("Ngày lập", 200);
            lsvImport.Columns.Add("Mã nhân viên", 100);
            HienThiNhapHang();
            setCboSearch();
        }

        private void lsvImport_ItemActivate(object sender, EventArgs e)
        {
            if (lsvImport.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvImport.SelectedItems[0];
                String impId = lvi.SubItems[0].Text;
                String suppId = lvi.SubItems[1].Text;
                String date = lvi.SubItems[2].Text;
                String EmpId = lvi.SubItems[3].Text;

                importDetailForm showOrder = new importDetailForm(getName, getId, impId, suppId, EmpId, date);
                showOrder.ShowDialog();
            }
        }

        private void picExit_Click(object sender, EventArgs e)
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
                for (int j = 0; j < lsvImport.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvImport.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvImport.Items.Count; i++)
                {
                    for (int j = 0; j < lsvImport.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvImport.Items[i].SubItems[j].Text;
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
                HienThiNhapHang();
            }
            else if (index == 1)
            {
                setListViewSearch("ImportID", data);
                txtContent.Text = "";
            }
            else if (index == 2)
            {
                setListViewSearch("SupplierID", data);
                txtContent.Text = "";
            }
            else if (index == 3)
            {
                setListViewSearch("EmpID", data);
                txtContent.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
            cmbTypeSearch.SelectedIndex = -1;
            HienThiNhapHang();
        }
    }
}
