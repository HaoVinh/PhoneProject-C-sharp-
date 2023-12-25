namespace MobileStore.GUI
{
    partial class ordDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordDetailForm));
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            picExit = new PictureBox();
            label1 = new Label();
            ABC = new Label();
            panel1 = new Panel();
            btnPrint = new Button();
            groupBox5 = new GroupBox();
            lblTotalAmount = new Label();
            tableOrderDetail = new DataGridView();
            groupBox4 = new GroupBox();
            txtDate = new Label();
            groupBox3 = new GroupBox();
            txtEmp = new Label();
            groupBox2 = new GroupBox();
            txtCus = new Label();
            groupBox1 = new GroupBox();
            txtOrderId = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableOrderDetail).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(picExit);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1277, 83);
            panel2.TabIndex = 6;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(210, 28);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 17;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(30, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(1198, 12);
            picExit.Margin = new Padding(3, 4, 3, 4);
            picExit.Name = "picExit";
            picExit.Size = new Size(41, 51);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 3;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
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
            ABC.ForeColor = Color.Black;
            ABC.Location = new Point(529, 20);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            ABC.Click += ABC_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(tableOrderDetail);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(1, 75);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 586);
            panel1.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Tomato;
            btnPrint.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = SystemColors.ControlLightLight;
            btnPrint.Location = new Point(153, 506);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 55);
            btnPrint.TabIndex = 29;
            btnPrint.Text = "In hóa đơn";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTotalAmount);
            groupBox5.Location = new Point(664, 493);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(234, 68);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tổng tiền";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(31, 34);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 20);
            lblTotalAmount.TabIndex = 1;
            // 
            // tableOrderDetail
            // 
            tableOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOrderDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableOrderDetail.Location = new Point(30, 148);
            tableOrderDetail.Name = "tableOrderDetail";
            tableOrderDetail.RowHeadersWidth = 51;
            tableOrderDetail.RowTemplate.Height = 29;
            tableOrderDetail.Size = new Size(1229, 319);
            tableOrderDetail.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDate);
            groupBox4.Location = new Point(986, 17);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(226, 68);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ngày lập hóa đơn";
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(47, 26);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(21, 20);
            txtDate.TabIndex = 1;
            txtDate.Text = "...";
            txtDate.TextChanged += txtDate_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEmp);
            groupBox3.Location = new Point(698, 17);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(200, 68);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mã nhân viên lập hóa đơn";
            // 
            // txtEmp
            // 
            txtEmp.AutoSize = true;
            txtEmp.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmp.Location = new Point(47, 26);
            txtEmp.Name = "txtEmp";
            txtEmp.Size = new Size(21, 20);
            txtEmp.TabIndex = 1;
            txtEmp.Text = "...";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCus);
            groupBox2.Location = new Point(417, 17);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(200, 68);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khách hàng";
            // 
            // txtCus
            // 
            txtCus.AutoSize = true;
            txtCus.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCus.Location = new Point(47, 26);
            txtCus.Name = "txtCus";
            txtCus.Size = new Size(21, 20);
            txtCus.TabIndex = 1;
            txtCus.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOrderId);
            groupBox1.Location = new Point(97, 17);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(200, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã hóa đơn";
            // 
            // txtOrderId
            // 
            txtOrderId.AutoSize = true;
            txtOrderId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderId.Location = new Point(47, 26);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(21, 20);
            txtOrderId.TabIndex = 1;
            txtOrderId.Text = "...";
            // 
            // ordDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 665);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ordDetailForm";
            Text = "ordDetailForm";
            Load += ordDetailForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableOrderDetail).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox picExit;
        private Label label1;
        private Label ABC;
        private Panel panel1;
        private GroupBox groupBox4;
        private Label txtDate;
        private GroupBox groupBox3;
        private Label txtEmp;
        private GroupBox groupBox2;
        private Label txtCus;
        private GroupBox groupBox1;
        private Label txtOrderId;
        private PictureBox pictureBox2;
        private DataGridView tableOrderDetail;
        private GroupBox groupBox5;
        private Label lblTotalAmount;
        private Button btnPrint;
        private Label txtAccName;
    }
}