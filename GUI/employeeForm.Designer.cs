namespace MobileStore
{
    partial class employeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeForm));
            groupBox3 = new GroupBox();
            btnSearch = new Button();
            cbxSearch = new ComboBox();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtEmpPosition = new TextBox();
            txtEmpAddress = new TextBox();
            txtEmpPhone = new TextBox();
            txtEmpName = new TextBox();
            txtEmpID = new TextBox();
            label8 = new Label();
            btnExportExcel = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ABC = new Label();
            lsvEmployee = new ListView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(cbxSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(873, 97);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(387, 197);
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
            btnSearch.Size = new Size(369, 43);
            btnSearch.TabIndex = 12;
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
            cbxSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(178, 65);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(175, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Tomato;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(178, 153);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 8;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(14, 153);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 51);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Tomato;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(178, 57);
            btnEdit.Margin = new Padding(2, 3, 2, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 51);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tomato;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 57);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 51);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmpPosition
            // 
            txtEmpPosition.Location = new Point(81, 115);
            txtEmpPosition.Margin = new Padding(2, 3, 2, 3);
            txtEmpPosition.Name = "txtEmpPosition";
            txtEmpPosition.Size = new Size(165, 27);
            txtEmpPosition.TabIndex = 2;
            // 
            // txtEmpAddress
            // 
            txtEmpAddress.Location = new Point(538, 83);
            txtEmpAddress.Margin = new Padding(2, 3, 2, 3);
            txtEmpAddress.Multiline = true;
            txtEmpAddress.Name = "txtEmpAddress";
            txtEmpAddress.Size = new Size(165, 73);
            txtEmpAddress.TabIndex = 4;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Location = new Point(538, 35);
            txtEmpPhone.Margin = new Padding(2, 3, 2, 3);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(165, 27);
            txtEmpPhone.TabIndex = 3;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(81, 75);
            txtEmpName.Margin = new Padding(2, 3, 2, 3);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(165, 27);
            txtEmpName.TabIndex = 1;
            // 
            // txtEmpID
            // 
            txtEmpID.Enabled = false;
            txtEmpID.Location = new Point(81, 35);
            txtEmpID.Margin = new Padding(2, 3, 2, 3);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(165, 27);
            txtEmpID.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(444, 83);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 5;
            label8.Text = "Địa Chỉ:";
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Tomato;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(98, 245);
            btnExportExcel.Margin = new Padding(2, 3, 2, 3);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(137, 51);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportExcel);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(873, 310);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(387, 331);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 38);
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
            label3.Text = "Mã NV:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtEmpPosition);
            groupBox1.Controls.Add(txtEmpAddress);
            groupBox1.Controls.Add(txtEmpPhone);
            groupBox1.Controls.Add(txtEmpName);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(0, 97);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(747, 197);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(270, 31);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 13;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 115);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 2;
            label5.Text = "Vị Trí:";
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
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(ABC);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 74);
            panel2.TabIndex = 9;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(171, 23);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 15;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1219, 14);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ABC
            // 
            ABC.AutoSize = true;
            ABC.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ABC.ForeColor = Color.Black;
            ABC.Location = new Point(579, 18);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 7;
            ABC.Text = "Alpha Mobile";
            // 
            // lsvEmployee
            // 
            lsvEmployee.Location = new Point(0, 367);
            lsvEmployee.Name = "lsvEmployee";
            lsvEmployee.Size = new Size(747, 274);
            lsvEmployee.TabIndex = 14;
            lsvEmployee.UseCompatibleStateImageBehavior = false;
            lsvEmployee.SelectedIndexChanged += lsvEmployee_SelectedIndexChanged;
            // 
            // employeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 695);
            Controls.Add(lsvEmployee);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "employeeForm";
            Text = "employeeForm";
            Load += employeeForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtEmpPosition;
        private TextBox txtEmpAddress;
        private TextBox txtEmpPhone;
        private TextBox txtEmpName;
        private TextBox txtEmpID;
        private Label label8;
        private Button btnExportExcel;
        private GroupBox groupBox2;
        private Label label7;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label1;
        private Panel panel2;
        private Label ABC;
        private PictureBox pictureBox1;
        private ListView lsvEmployee;
        private PictureBox pictureBox2;
        private Label txtAccName;
        private Button button1;
    }
}