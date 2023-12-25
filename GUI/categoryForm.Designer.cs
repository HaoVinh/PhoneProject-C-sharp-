namespace MobileStore
{
    partial class categoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryForm));
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            ABC = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbTypeSearch = new ComboBox();
            groupBox18 = new GroupBox();
            txtContent = new TextBox();
            btnSearch = new Button();
            groupBox17 = new GroupBox();
            groupBox14 = new GroupBox();
            groupBox2 = new GroupBox();
            txtCateID = new TextBox();
            txtCateName = new TextBox();
            groupBox4 = new GroupBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnExportEcel = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            groupBox7 = new GroupBox();
            panel1 = new Panel();
            lsvCategory = new ListView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox18.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(ABC);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 78);
            panel2.TabIndex = 3;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(184, 18);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 9;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(4, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // ABC
            // 
            ABC.AutoSize = true;
            ABC.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ABC.ForeColor = Color.Black;
            ABC.Location = new Point(567, 18);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 6;
            ABC.Text = "Alpha Mobile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1203, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
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
            // cmbTypeSearch
            // 
            cmbTypeSearch.FormattingEnabled = true;
            cmbTypeSearch.Location = new Point(13, 23);
            cmbTypeSearch.Margin = new Padding(3, 4, 3, 4);
            cmbTypeSearch.Name = "cmbTypeSearch";
            cmbTypeSearch.Size = new Size(138, 28);
            cmbTypeSearch.TabIndex = 8;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(cmbTypeSearch);
            groupBox18.Location = new Point(23, 41);
            groupBox18.Margin = new Padding(3, 4, 3, 4);
            groupBox18.Name = "groupBox18";
            groupBox18.Padding = new Padding(3, 4, 3, 4);
            groupBox18.Size = new Size(166, 67);
            groupBox18.TabIndex = 1;
            groupBox18.TabStop = false;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(27, 24);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(114, 27);
            txtContent.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(152, 141);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 55);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(txtContent);
            groupBox17.Location = new Point(213, 45);
            groupBox17.Margin = new Padding(3, 4, 3, 4);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(3, 4, 3, 4);
            groupBox17.Size = new Size(163, 63);
            groupBox17.TabIndex = 2;
            groupBox17.TabStop = false;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(btnSearch);
            groupBox14.Controls.Add(groupBox17);
            groupBox14.Controls.Add(groupBox18);
            groupBox14.Location = new Point(803, 97);
            groupBox14.Margin = new Padding(3, 4, 3, 4);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 4, 3, 4);
            groupBox14.Size = new Size(408, 223);
            groupBox14.TabIndex = 13;
            groupBox14.TabStop = false;
            groupBox14.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCateID);
            groupBox2.Location = new Point(42, 71);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(163, 69);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mã thể loại";
            // 
            // txtCateID
            // 
            txtCateID.Enabled = false;
            txtCateID.Location = new Point(19, 22);
            txtCateID.Margin = new Padding(3, 4, 3, 4);
            txtCateID.Name = "txtCateID";
            txtCateID.Size = new Size(114, 27);
            txtCateID.TabIndex = 2;
            // 
            // txtCateName
            // 
            txtCateName.Location = new Point(27, 24);
            txtCateName.Margin = new Padding(3, 4, 3, 4);
            txtCateName.Name = "txtCateName";
            txtCateName.Size = new Size(114, 27);
            txtCateName.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtCateName);
            groupBox4.Location = new Point(329, 69);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(163, 71);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên thể loại";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(3, 97);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(657, 223);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin danh mục";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(42, 152);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 2;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExportEcel
            // 
            btnExportEcel.BackColor = Color.Tomato;
            btnExportEcel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportEcel.ForeColor = SystemColors.ControlLightLight;
            btnExportEcel.Location = new Point(152, 273);
            btnExportEcel.Margin = new Padding(3, 4, 3, 4);
            btnExportEcel.Name = "btnExportEcel";
            btnExportEcel.Size = new Size(120, 55);
            btnExportEcel.TabIndex = 7;
            btnExportEcel.Text = "Xuất Excel";
            btnExportEcel.UseVisualStyleBackColor = false;
            btnExportEcel.Click += btnExportEcel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(240, 186);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 55);
            btnClear.TabIndex = 6;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Tomato;
            btnEdit.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(51, 186);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 55);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(240, 83);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 55);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tomato;
            btnAdd.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(51, 83);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 55);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnExportEcel);
            groupBox7.Controls.Add(btnClear);
            groupBox7.Controls.Add(btnEdit);
            groupBox7.Controls.Add(btnDelete);
            groupBox7.Controls.Add(btnAdd);
            groupBox7.Location = new Point(803, 340);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(408, 345);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thao tác";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lsvCategory);
            panel1.Controls.Add(groupBox7);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox14);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 704);
            panel1.TabIndex = 2;
            // 
            // lsvCategory
            // 
            lsvCategory.Location = new Point(3, 340);
            lsvCategory.Name = "lsvCategory";
            lsvCategory.Size = new Size(657, 345);
            lsvCategory.TabIndex = 16;
            lsvCategory.UseCompatibleStateImageBehavior = false;
            lsvCategory.SelectedIndexChanged += lsvCategory_SelectedIndexChanged;
            // 
            // categoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 705);
            Controls.Add(panel1);
            Name = "categoryForm";
            Text = "categoryForm";
            Load += categoryForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox18.ResumeLayout(false);
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private ComboBox cmbTypeSearch;
        private GroupBox groupBox18;
        private TextBox txtContent;
        private Button btnSearch;
        private GroupBox groupBox17;
        private GroupBox groupBox14;
        private GroupBox groupBox2;
        private TextBox txtCateName;
        private GroupBox groupBox4;
        private GroupBox groupBox1;
        private Button btnExportEcel;
        private Button btnClear;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private GroupBox groupBox7;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label ABC;
        private ListView lsvCategory;
        private TextBox txtCateID;
        private PictureBox pictureBox2;
        private Label txtAccName;
        private Button button1;
    }
}