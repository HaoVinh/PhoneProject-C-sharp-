namespace MobileStore.GUI
{
    partial class customerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ABC = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtCusAddress = new TextBox();
            txtCusPhone = new TextBox();
            txtCusName = new TextBox();
            txtCusID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnSearch = new Button();
            cbxSearch = new ComboBox();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            btnExportExcel = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lsvCustomer = new ListView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 82);
            panel2.TabIndex = 10;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(183, 32);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 16;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1223, 13);
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
            ABC.Location = new Point(614, 24);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtCusAddress);
            groupBox1.Controls.Add(txtCusPhone);
            groupBox1.Controls.Add(txtCusName);
            groupBox1.Controls.Add(txtCusID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(11, 104);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(753, 208);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(278, 35);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 14;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCusAddress
            // 
            txtCusAddress.Location = new Point(570, 80);
            txtCusAddress.Margin = new Padding(2, 3, 2, 3);
            txtCusAddress.Multiline = true;
            txtCusAddress.Name = "txtCusAddress";
            txtCusAddress.Size = new Size(165, 73);
            txtCusAddress.TabIndex = 3;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Location = new Point(569, 35);
            txtCusPhone.Margin = new Padding(2, 3, 2, 3);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(165, 27);
            txtCusPhone.TabIndex = 2;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(81, 75);
            txtCusName.Margin = new Padding(2, 3, 2, 3);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(165, 27);
            txtCusName.TabIndex = 1;
            // 
            // txtCusID
            // 
            txtCusID.Enabled = false;
            txtCusID.Location = new Point(81, 35);
            txtCusID.Margin = new Padding(2, 3, 2, 3);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(165, 27);
            txtCusID.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(485, 80);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 5;
            label8.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 35);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 4;
            label7.Text = "Điện Thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 1;
            label4.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã KH:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(cbxSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(900, 104);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(328, 197);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(14, 104);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(310, 43);
            btnSearch.TabIndex = 11;
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
            cbxSearch.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(149, 64);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(175, 27);
            txtSearch.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportExcel);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(900, 307);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(328, 331);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Tomato;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(97, 247);
            btnExportExcel.Margin = new Padding(2, 3, 2, 3);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(137, 51);
            btnExportExcel.TabIndex = 8;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Tomato;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(177, 133);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 7;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(14, 133);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 51);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Tomato;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(177, 29);
            btnEdit.Margin = new Padding(2, 3, 2, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 51);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tomato;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 29);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 51);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lsvCustomer
            // 
            lsvCustomer.Location = new Point(11, 351);
            lsvCustomer.Name = "lsvCustomer";
            lsvCustomer.Size = new Size(753, 297);
            lsvCustomer.TabIndex = 15;
            lsvCustomer.UseCompatibleStateImageBehavior = false;
            lsvCustomer.SelectedIndexChanged += lsvCustomer_SelectedIndexChanged;
            // 
            // customerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 755);
            Controls.Add(lsvCustomer);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "customerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customerForm";
            FormClosing += customerForm_FormClosing;
            Load += customerForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label ABC;
        private GroupBox groupBox1;
        private TextBox txtCusAddress;
        private TextBox txtCusPhone;
        private TextBox txtCusName;
        private TextBox txtCusID;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Button btnExportExcel;
        private Button btnReset;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ListView lsvCustomer;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label txtAccName;
        private Button button1;
    }
}