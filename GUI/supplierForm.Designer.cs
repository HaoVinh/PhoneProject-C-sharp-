namespace MobileStore.GUI
{
    partial class supplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplierForm));
            btnExportExcel = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            btnDel = new Button();
            btnEdit = new Button();
            txtSearch = new TextBox();
            txtSupAddress = new TextBox();
            txtSupPhone = new TextBox();
            txtSupName = new TextBox();
            txtSupID = new TextBox();
            label8 = new Label();
            btnSearch = new Button();
            cbxSearch = new ComboBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtSupContact = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ABC = new Label();
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lsvSupplier = new ListView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Tomato;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(113, 240);
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
            btnReset.Location = new Point(210, 137);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 7;
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
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDel);
            groupBox2.Controls.Add(btnExportExcel);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(874, 380);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(376, 331);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Tomato;
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(14, 137);
            btnDel.Margin = new Padding(2, 3, 2, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(137, 51);
            btnDel.TabIndex = 9;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Tomato;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(210, 29);
            btnEdit.Margin = new Padding(2, 3, 2, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 51);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(166, 64);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 27);
            txtSearch.TabIndex = 10;
            // 
            // txtSupAddress
            // 
            txtSupAddress.Location = new Point(548, 83);
            txtSupAddress.Margin = new Padding(2, 3, 2, 3);
            txtSupAddress.Multiline = true;
            txtSupAddress.Name = "txtSupAddress";
            txtSupAddress.Size = new Size(165, 73);
            txtSupAddress.TabIndex = 4;
            // 
            // txtSupPhone
            // 
            txtSupPhone.Location = new Point(547, 38);
            txtSupPhone.Margin = new Padding(2, 3, 2, 3);
            txtSupPhone.Name = "txtSupPhone";
            txtSupPhone.Size = new Size(165, 27);
            txtSupPhone.TabIndex = 3;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(81, 75);
            txtSupName.Margin = new Padding(2, 3, 2, 3);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(165, 27);
            txtSupName.TabIndex = 1;
            // 
            // txtSupID
            // 
            txtSupID.Enabled = false;
            txtSupID.Location = new Point(81, 35);
            txtSupID.Margin = new Padding(2, 3, 2, 3);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(165, 27);
            txtSupID.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 83);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 5;
            label8.Text = "Địa Chỉ:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(14, 104);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(353, 43);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(cbxSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(874, 122);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(376, 197);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 38);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 4;
            label7.Text = "Điện Thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên NCC:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSupContact);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSupAddress);
            groupBox1.Controls.Add(txtSupPhone);
            groupBox1.Controls.Add(txtSupName);
            groupBox1.Controls.Add(txtSupID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(11, 110);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(734, 251);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(264, 34);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 13;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSupContact
            // 
            txtSupContact.Location = new Point(81, 111);
            txtSupContact.Margin = new Padding(2, 3, 2, 3);
            txtSupContact.Name = "txtSupContact";
            txtSupContact.Size = new Size(165, 27);
            txtSupContact.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 10;
            label2.Text = "Liên hệ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã NCC:";
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
            ABC.Location = new Point(586, 18);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(2, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 81);
            panel2.TabIndex = 15;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(199, 25);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 21;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(9, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1198, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lsvSupplier
            // 
            lsvSupplier.Location = new Point(12, 368);
            lsvSupplier.Name = "lsvSupplier";
            lsvSupplier.Size = new Size(733, 375);
            lsvSupplier.TabIndex = 20;
            lsvSupplier.UseCompatibleStateImageBehavior = false;
            lsvSupplier.SelectedIndexChanged += lsvSupplier_SelectedIndexChanged;
            // 
            // supplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 755);
            Controls.Add(lsvSupplier);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "supplierForm";
            Text = "supplierForm";
            Load += supplierForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExportExcel;
        private Button btnReset;
        private Button btnAdd;
        private GroupBox groupBox2;
        private Button btnEdit;
        private TextBox txtSearch;
        private TextBox txtSupAddress;
        private TextBox txtSupPhone;
        private TextBox txtSupName;
        private TextBox txtSupID;
        private Label label8;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private GroupBox groupBox3;
        private Label label7;
        private Label label4;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label ABC;
        private Panel panel2;
        private TextBox txtSupContact;
        private Label label2;
        private ListView lsvSupplier;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label txtAccName;
        private Button button1;
        private Button btnDel;
    }
}