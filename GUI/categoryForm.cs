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
using OfficeOpenXml;

namespace MobileStore
{
    public partial class categoryForm : Form
    {
        private categoryBUS cate_BUS = new categoryBUS();
        RegexPattern regex = new RegexPattern();
        String empID = "";
        String empName = "";
        public categoryForm(String name, String id)
        {
            InitializeComponent();
            empID = id;
            empName = name;
            txtAccName.Text = name + "(" + id + ")";
        }
        void HienThiLoai()
        {
            lsvCategory.Items.Clear();
            DataTable dt = cate_BUS.LayDSLoai();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvCategory.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());

            }
        }

        private void categoryForm_Load(object sender, EventArgs e)
        {
            lsvCategory.View = View.Details;
            lsvCategory.GridLines = true;
            lsvCategory.FullRowSelect = true;
            lsvCategory.Columns.Add("Mã thể loại", 80);
            lsvCategory.Columns.Add("Tên thể loại", 150);
            HienThiLoai();
            setCboSearch();
        }
        public void setCboSearch()
        {
            cmbTypeSearch.Items.Add("Tất cả");
            cmbTypeSearch.Items.Add("Mã Loại");
            cmbTypeSearch.Items.Add("Tên Loại");
        }
        public void setListViewSearchByID(String data)
        {
            lsvCategory.Items.Clear();
            List<categoryDTO> dt = cate_BUS.searchCategoryByID(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy loại sản phẩm với mã " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (categoryDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getCategoryID());
                lvi.SubItems.Add(cus.getCategoryName());


                lsvCategory.Items.Add(lvi);
            }
        }
        public void setListViewSearchByName(String data)
        {
            lsvCategory.Items.Clear();
            List<categoryDTO> dt = cate_BUS.searchCategoryByName(data);
            if (dt.Count == 0)
            {
                MessageBox.Show("Không tìm thấy loại sản phẩm với tên " + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (categoryDTO cus in dt)
            {
                ListViewItem lvi = new ListViewItem(cus.getCategoryID());
                lvi.SubItems.Add(cus.getCategoryName());


                lsvCategory.Items.Add(lvi);
            }
        }

        private void lsvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvCategory.SelectedItems[0];
                txtCateID.Text = selectedItem.SubItems[0].Text;
                txtCateName.Text = selectedItem.SubItems[1].Text;

            }
        }
        public void resetData()
        {
            txtCateID.Text = "";
            txtCateName.Text = "";

            HienThiLoai();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtCateName.Text.Trim().Equals("")/* || txtCateID.Text.Trim().Equals("")*/))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string newID = "TL" + (cate_BUS.LayMaTLMax() + 1).ToString();
                string id = newID, catename = txtCateName.Text;
                categoryDTO cate = new categoryDTO(id, catename);
                DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (cate_BUS.ThemLoai(cate))
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
            String id = txtCateID.Text;
            if (cate_BUS.XoaLoai(id))
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

            if ((txtCateName.Text.Trim().Equals("") || txtCateID.Text.Trim().Equals("")))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string id = txtCateID.Text, catename = txtCateName.Text;
                categoryDTO cate = new categoryDTO(id, catename);

                if (cate_BUS.CapNhatLoai(cate))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa dữ liệu này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
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
                HienThiLoai();
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

        private void btnExportEcel_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một Worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Ghi tên cột vào Excel Worksheet
                for (int j = 0; j < lsvCategory.Columns.Count; j++)
                {
                    worksheet.Cells[1, j + 1].Value = lsvCategory.Columns[j].Text;
                }

                // Ghi dữ liệu từ ListView vào Excel Worksheet
                for (int i = 0; i < lsvCategory.Items.Count; i++)
                {
                    for (int j = 0; j < lsvCategory.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = lsvCategory.Items[i].SubItems[j].Text;
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
            int b = cate_BUS.LayMaTLMax() + 1;

            txtCateID.Text = "TL" + b.ToString();
        }
    }
}
