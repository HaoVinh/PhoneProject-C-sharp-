namespace MobileStore.GUI
{
    partial class productForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productForm));
            label2 = new Label();
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ABC = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lblImage = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            txtQuantity = new TextBox();
            cboProducts_BrandID = new ComboBox();
            cboProducts_CateID = new ComboBox();
            label6 = new Label();
            txtProductsPrice = new TextBox();
            txtProductsName = new TextBox();
            txtProductsID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            cboSearch2 = new ComboBox();
            btnSearch = new Button();
            cbxSearch = new ComboBox();
            txtSearch = new TextBox();
            btnEdit = new Button();
            groupBox2 = new GroupBox();
            btnExportExcel = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            lsvProduct = new ListView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 10;
            label2.Text = "Giá:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 89);
            panel2.TabIndex = 20;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(201, 32);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 10;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(21, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1221, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // ABC
            // 
            ABC.AutoSize = true;
            ABC.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ABC.ForeColor = SystemColors.ActiveCaptionText;
            ABC.Location = new Point(559, 25);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            ABC.Click += ABC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã SP:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblImage);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(cboProducts_BrandID);
            groupBox1.Controls.Add(cboProducts_CateID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtProductsPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtProductsName);
            groupBox1.Controls.Add(txtProductsID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 117);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(840, 230);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(413, 157);
            lblImage.Margin = new Padding(2, 0, 2, 0);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(71, 20);
            lblImage.TabIndex = 6;
            lblImage.Text = "Hình ảnh:";
            lblImage.Click += lblImage_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(624, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 201);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(264, 30);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 19;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(486, 30);
            txtQuantity.Margin = new Padding(2, 3, 2, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(119, 27);
            txtQuantity.TabIndex = 3;
            // 
            // cboProducts_BrandID
            // 
            cboProducts_BrandID.FormattingEnabled = true;
            cboProducts_BrandID.Location = new Point(486, 69);
            cboProducts_BrandID.Margin = new Padding(2, 3, 2, 3);
            cboProducts_BrandID.Name = "cboProducts_BrandID";
            cboProducts_BrandID.Size = new Size(119, 28);
            cboProducts_BrandID.TabIndex = 4;
            // 
            // cboProducts_CateID
            // 
            cboProducts_CateID.FormattingEnabled = true;
            cboProducts_CateID.Location = new Point(486, 107);
            cboProducts_CateID.Margin = new Padding(2, 3, 2, 3);
            cboProducts_CateID.Name = "cboProducts_CateID";
            cboProducts_CateID.Size = new Size(119, 28);
            cboProducts_CateID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 113);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 13;
            label6.Text = "Mã loại:";
            // 
            // txtProductsPrice
            // 
            txtProductsPrice.Location = new Point(81, 111);
            txtProductsPrice.Margin = new Padding(2, 3, 2, 3);
            txtProductsPrice.Name = "txtProductsPrice";
            txtProductsPrice.Size = new Size(165, 27);
            txtProductsPrice.TabIndex = 2;
            // 
            // txtProductsName
            // 
            txtProductsName.Location = new Point(81, 75);
            txtProductsName.Margin = new Padding(2, 3, 2, 3);
            txtProductsName.Name = "txtProductsName";
            txtProductsName.Size = new Size(165, 27);
            txtProductsName.TabIndex = 1;
            // 
            // txtProductsID
            // 
            txtProductsID.Enabled = false;
            txtProductsID.Location = new Point(81, 35);
            txtProductsID.Margin = new Padding(2, 3, 2, 3);
            txtProductsID.Name = "txtProductsID";
            txtProductsID.Size = new Size(165, 27);
            txtProductsID.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 73);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 5;
            label8.Text = "Mã TH:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 32);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 4;
            label7.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên SP:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(cbxSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(902, 117);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(328, 296);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboSearch2);
            groupBox4.Location = new Point(5, 173);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(318, 108);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm nâng cao";
            // 
            // cboSearch2
            // 
            cboSearch2.FormattingEnabled = true;
            cboSearch2.Location = new Point(9, 48);
            cboSearch2.Margin = new Padding(2, 3, 2, 3);
            cboSearch2.Name = "cboSearch2";
            cboSearch2.Size = new Size(299, 28);
            cboSearch2.TabIndex = 14;
            cboSearch2.SelectedIndexChanged += cboSearch2_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(14, 103);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(301, 43);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbxSearch
            // 
            cbxSearch.FormattingEnabled = true;
            cbxSearch.Location = new Point(14, 64);
            cbxSearch.Margin = new Padding(2, 3, 2, 3);
            cbxSearch.Name = "cbxSearch";
            cbxSearch.Size = new Size(119, 28);
            cbxSearch.TabIndex = 11;
            cbxSearch.SelectedIndexChanged += cbxSearch_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(148, 64);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(175, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Tomato;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(177, 29);
            btnEdit.Margin = new Padding(2, 3, 2, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 51);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportExcel);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(902, 446);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(328, 255);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Tomato;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(178, 139);
            btnExportExcel.Margin = new Padding(2, 3, 2, 3);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(137, 51);
            btnExportExcel.TabIndex = 10;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Tomato;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(14, 139);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 9;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tomato;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 29);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 51);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(16, 368);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(832, 357);
            lsvProduct.TabIndex = 25;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            lsvProduct.SelectedIndexChanged += lsvProduct_SelectedIndexChanged;
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 755);
            Controls.Add(lsvProduct);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "productForm";
            Text = "productForm";
            Load += productForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label ABC;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtProductsPrice;
        private TextBox txtProductsName;
        private TextBox txtProductsID;
        private Label label8;
        private Label label7;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private TextBox txtSearch;
        private Button btnEdit;
        private GroupBox groupBox2;
        private Button btnExportExcel;
        private Button btnReset;
        private Button btnAdd;
        private ComboBox cboProducts_BrandID;
        private ComboBox cboProducts_CateID;
        private Label label6;
        private ListView lsvProduct;
        private TextBox txtQuantity;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label txtAccName;
        private Button button1;
        private Label lblImage;
        private PictureBox pictureBox3;
        private ComboBox cboSearch2;
        private GroupBox groupBox4;
    }
}