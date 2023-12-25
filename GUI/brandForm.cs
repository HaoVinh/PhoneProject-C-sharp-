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
    public partial class brandForm : Form
    {
        private brandBUS brand_BUS = new brandBUS();
        RegexPattern regex = new RegexPattern();
        String empID = "";
        String empName = "";
        public brandForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
        }
        void HienThiTH()
        {
            lsvBrand.Items.Clear();
            DataTable dt = brand_BUS.LayDSTH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvBrand.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());

            }
        }

        private void brandForm_Load(object sender, EventArgs e)
        {
            lsvBrand.View = View.Details;
            lsvBrand.GridLines = true;
            lsvBrand.FullRowSelect = true;
            lsvBrand.Columns.Add("Mã thương hiệu", 80);
            lsvBrand.Columns.Add("Tên thương hiệu", 150);
            HienThiTH();
            setCboSearch();
        }
        public void setCboSearch()
        {
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã TH");
            cmbTypeSearch.Items.Add("Tên TH");
        }
        public void setListViewSearchByID(String data)
        {
            lsvBrand.Items.Clear();
            List<brandDTO> dt = brand_BUS.searchBrandByID(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thương hiệu với mã " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (brandDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getBrandID());
                lvi.SubItems.Add(cus.getBrandName());


                lsvBrand.Items.Add(lvi);
            }
        }
        public void setListViewSearchByName(String data)
        {
            lsvBrand.Items.Clear();
            List<brandDTO> dt = brand_BUS.searchBrandByName(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thương hiệu với tên " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (brandDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getBrandID());
                lvi.SubItems.Add(cus.getBrandName());


                lsvBrand.Items.Add(lvi);
            }
        }

        private void lsvBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBrand.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvBrand.SelectedItems[0];
                txtBrandID.Text = selectedItem.SubItems[0].Text;
                txtBrandName.Text = selectedItem.SubItems[1].Text;

            }
        }
        public void resetData()
        {
            txtBrandID.Text = "";
            txtBrandName.Text = "";

            HienThiTH();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtBrandName.Text.Trim().Equals("") /*|| txtBrandID.Text.Trim().Equals("")*/))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string newID = "TH" + (brand_BUS.LayMaTHMax() + 1).ToString();
                string id = newID, brandname = txtBrandName.Text;
                brandDTO brand = new brandDTO(id, brandname);
                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (brand_BUS.ThemTH(brand))
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtBrandID.Text;
            if (brand_BUS.XoaTH(id))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    resetData();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((txtBrandName.Text.Trim().Equals("") || txtBrandID.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string id = txtBrandID.Text, brandname = txtBrandName.Text;
                brandDTO brand = new brandDTO(id, brandname);
                DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận sửa dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (brand_BUS.CapNhatTH(brand))
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetData();
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
                HienThiTH();
            }
            else if (index == 1)
            {
                setListViewSearchByID(data);
                txtContent.Text = "";
            }
            else if (index == 2)
            {
                setListViewSearchByName(data);
                txtContent.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void brandForm_FormClosing(object sender, FormClosingEventArgs e)
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
                for (int j = 0; j < lsvBrand.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvBrand.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvBrand.Items.Count; i++)
                {
                    for (int j = 0; j < lsvBrand.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvBrand.Items[i].SubItems[j].Text;
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
            int b = brand_BUS.LayMaTHMax() + 1;

            txtBrandID.Text = "TH" + b.ToString();
        }
    }
}
