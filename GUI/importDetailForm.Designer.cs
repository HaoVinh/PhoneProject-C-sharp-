namespace MobileStore.GUI
{
    partial class importDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importDetailForm));
            txtImportId = new Label();
            txtSupp = new Label();
            txtEmp = new Label();
            txtDate = new Label();
            groupBox1 = new GroupBox();
            ABC = new Label();
            groupBox4 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            picExit = new PictureBox();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnPrint = new Button();
            groupBox5 = new GroupBox();
            lblTotalAmount = new Label();
            tableImportDetail = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableImportDetail).BeginInit();
            SuspendLayout();
            // 
            // txtImportId
            // 
            txtImportId.AutoSize = true;
            txtImportId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportId.Location = new Point(47, 27);
            txtImportId.Name = "txtImportId";
            txtImportId.Size = new Size(21, 20);
            txtImportId.TabIndex = 1;
            txtImportId.Text = "...";
            // 
            // txtSupp
            // 
            txtSupp.AutoSize = true;
            txtSupp.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupp.Location = new Point(47, 27);
            txtSupp.Name = "txtSupp";
            txtSupp.Size = new Size(21, 20);
            txtSupp.TabIndex = 1;
            txtSupp.Text = "...";
            // 
            // txtEmp
            // 
            txtEmp.AutoSize = true;
            txtEmp.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmp.Location = new Point(46, 27);
            txtEmp.Name = "txtEmp";
            txtEmp.Size = new Size(21, 20);
            txtEmp.TabIndex = 1;
            txtEmp.Text = "...";
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(47, 27);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(21, 20);
            txtDate.TabIndex = 1;
            txtDate.Text = "...";
            txtDate.TextChanged += txtDate_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtImportId);
            groupBox1.Location = new Point(30, 17);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(200, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã đơn nhập";
            // 
            // ABC
            // 
            ABC.AutoSize = true;
            ABC.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ABC.ForeColor = Color.Black;
            ABC.Location = new Point(610, 20);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtEmp);
            groupBox4.Location = new Point(683, 19);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(226, 68);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mã nhân viên lập đơn";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDate);
            groupBox3.Location = new Point(997, 19);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(234, 68);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ngày lập đơn nhập";
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(1225, 9);
            picExit.Margin = new Padding(3, 4, 3, 4);
            picExit.Name = "picExit";
            picExit.Size = new Size(41, 51);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 3;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSupp);
            groupBox2.Location = new Point(344, 19);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(200, 68);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhà cung cấp";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(picExit);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(-1, -1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1299, 76);
            panel2.TabIndex = 8;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(178, 27);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 16;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(tableImportDetail);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(-1, 82);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1299, 605);
            panel1.TabIndex = 9;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Tomato;
            btnPrint.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = SystemColors.ControlLightLight;
            btnPrint.Location = new Point(155, 499);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 55);
            btnPrint.TabIndex = 30;
            btnPrint.Text = "In hóa đơn";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTotalAmount);
            groupBox5.Location = new Point(831, 486);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(234, 68);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tổng tiền";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(31, 33);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 20);
            lblTotalAmount.TabIndex = 1;
            // 
            // tableImportDetail
            // 
            tableImportDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableImportDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableImportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportDetail.Location = new Point(13, 123);
            tableImportDetail.Name = "tableImportDetail";
            tableImportDetail.RowHeadersWidth = 51;
            tableImportDetail.RowTemplate.Height = 29;
            tableImportDetail.Size = new Size(1253, 353);
            tableImportDetail.TabIndex = 8;
            // 
            // importDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 687);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "importDetailForm";
            Text = "importDetailForm";
            Load += importDetailForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableImportDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txtImportId;
        private Label txtSupp;
        private Label txtEmp;
        private Label txtDate;
        private GroupBox groupBox1;
        private Label ABC;
        private GroupBox groupBox4;
        private Label label1;
        private GroupBox groupBox3;
        private PictureBox picExit;
        private GroupBox groupBox2;
        private Panel panel2;
        private Panel panel1;
        private DataGridView tableImportDetail;
        private PictureBox pictureBox2;
        private GroupBox groupBox5;
        private Label lblTotalAmount;
        private Button btnPrint;
        private Label txtAccName;
    }
}