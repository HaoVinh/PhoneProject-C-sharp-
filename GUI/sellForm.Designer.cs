namespace MobileStore.GUI
{
    partial class sellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sellForm));
            panel1 = new Panel();
            lsvOrder = new ListView();
            btnPay = new Button();
            btnCancel = new Button();
            groupBox20 = new GroupBox();
            txtPriceAll = new Label();
            btnClear = new Button();
            btnAddProduct = new Button();
            groupBox1 = new GroupBox();
            lsvProduct = new ListView();
            groupBox2 = new GroupBox();
            groupBox6 = new GroupBox();
            txtQuantity = new TextBox();
            groupBox5 = new GroupBox();
            txtPrice = new Label();
            groupBox4 = new GroupBox();
            txtProductName = new Label();
            groupBox3 = new GroupBox();
            txtCateId = new Label();
            groupBox13 = new GroupBox();
            txtProductId = new Label();
            groupBox7 = new GroupBox();
            groupBox14 = new GroupBox();
            cboDiscount = new ComboBox();
            groupBox12 = new GroupBox();
            txtPricePro = new Label();
            groupBox10 = new GroupBox();
            txtEmpName = new Label();
            groupBox11 = new GroupBox();
            dtpOrder = new DateTimePicker();
            groupBox9 = new GroupBox();
            cmbCusName = new ComboBox();
            groupBox8 = new GroupBox();
            button1 = new Button();
            txtOrderID = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtAccName = new Label();
            label1 = new Label();
            ABC = new Label();
            panel1.SuspendLayout();
            groupBox20.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lsvOrder);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(groupBox20);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-9, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 879);
            panel1.TabIndex = 2;
            // 
            // lsvOrder
            // 
            lsvOrder.Location = new Point(774, 351);
            lsvOrder.Name = "lsvOrder";
            lsvOrder.Size = new Size(500, 307);
            lsvOrder.TabIndex = 20;
            lsvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Tomato;
            btnPay.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.ForeColor = SystemColors.ControlLightLight;
            btnPay.Location = new Point(1004, 722);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(168, 55);
            btnPay.TabIndex = 19;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(780, 722);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 55);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(txtPriceAll);
            groupBox20.Location = new Point(991, 661);
            groupBox20.Margin = new Padding(3, 4, 3, 4);
            groupBox20.Name = "groupBox20";
            groupBox20.Padding = new Padding(3, 4, 3, 4);
            groupBox20.Size = new Size(163, 53);
            groupBox20.TabIndex = 17;
            groupBox20.TabStop = false;
            groupBox20.Text = "Tổng tiền";
            // 
            // txtPriceAll
            // 
            txtPriceAll.AutoSize = true;
            txtPriceAll.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceAll.Location = new Point(59, 27);
            txtPriceAll.Name = "txtPriceAll";
            txtPriceAll.Size = new Size(21, 20);
            txtPriceAll.TabIndex = 0;
            txtPriceAll.Text = "...";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(780, 659);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 55);
            btnClear.TabIndex = 16;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Tomato;
            btnAddProduct.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.ForeColor = SystemColors.ControlLightLight;
            btnAddProduct.Location = new Point(280, 695);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(275, 55);
            btnAddProduct.TabIndex = 12;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvProduct);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(7, 93);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(736, 431);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập sản phẩm";
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(0, 240);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(736, 347);
            lsvProduct.TabIndex = 10;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            lsvProduct.ItemSelectionChanged += lsvProduct_ItemSelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox13);
            groupBox2.Location = new Point(5, 28);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(725, 205);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtQuantity);
            groupBox6.Location = new Point(443, 103);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(136, 73);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(15, 29);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(114, 27);
            txtQuantity.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtPrice);
            groupBox5.Location = new Point(525, 32);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(166, 63);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Đơn giá";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(33, 27);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(21, 20);
            txtPrice.TabIndex = 1;
            txtPrice.Text = "...";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtProductName);
            groupBox4.Location = new Point(251, 32);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(219, 63);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.AutoSize = true;
            txtProductName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(27, 27);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(21, 20);
            txtProductName.TabIndex = 1;
            txtProductName.Text = "...";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCateId);
            groupBox3.Location = new Point(89, 109);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(166, 67);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại sản phẩm";
            // 
            // txtCateId
            // 
            txtCateId.AutoSize = true;
            txtCateId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCateId.Location = new Point(33, 27);
            txtCateId.Name = "txtCateId";
            txtCateId.Size = new Size(21, 20);
            txtCateId.TabIndex = 1;
            txtCateId.Text = "...";
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(txtProductId);
            groupBox13.Location = new Point(7, 32);
            groupBox13.Margin = new Padding(3, 4, 3, 4);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(3, 4, 3, 4);
            groupBox13.Size = new Size(163, 61);
            groupBox13.TabIndex = 0;
            groupBox13.TabStop = false;
            groupBox13.Text = "Mã sản phẩm";
            // 
            // txtProductId
            // 
            txtProductId.AutoSize = true;
            txtProductId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductId.Location = new Point(27, 27);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(21, 20);
            txtProductId.TabIndex = 1;
            txtProductId.Text = "...";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox14);
            groupBox7.Controls.Add(groupBox12);
            groupBox7.Controls.Add(groupBox10);
            groupBox7.Controls.Add(groupBox11);
            groupBox7.Controls.Add(groupBox9);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Location = new Point(774, 111);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(500, 233);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(cboDiscount);
            groupBox14.Location = new Point(16, 164);
            groupBox14.Margin = new Padding(3, 4, 3, 4);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 4, 3, 4);
            groupBox14.Size = new Size(163, 69);
            groupBox14.TabIndex = 6;
            groupBox14.TabStop = false;
            groupBox14.Text = "Mã giảm giá";
            // 
            // cboDiscount
            // 
            cboDiscount.FormattingEnabled = true;
            cboDiscount.Location = new Point(14, 25);
            cboDiscount.Margin = new Padding(3, 4, 3, 4);
            cboDiscount.Name = "cboDiscount";
            cboDiscount.Size = new Size(138, 28);
            cboDiscount.TabIndex = 0;
            cboDiscount.SelectedIndexChanged += cboDiscount_SelectedIndexChanged;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(txtPricePro);
            groupBox12.Location = new Point(246, 172);
            groupBox12.Margin = new Padding(3, 4, 3, 4);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(3, 4, 3, 4);
            groupBox12.Size = new Size(248, 53);
            groupBox12.TabIndex = 5;
            groupBox12.TabStop = false;
            groupBox12.Text = "Tổng tiền";
            // 
            // txtPricePro
            // 
            txtPricePro.AutoSize = true;
            txtPricePro.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPricePro.Location = new Point(37, 27);
            txtPricePro.Name = "txtPricePro";
            txtPricePro.Size = new Size(21, 20);
            txtPricePro.TabIndex = 0;
            txtPricePro.Text = "...";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(txtEmpName);
            groupBox10.Location = new Point(16, 93);
            groupBox10.Margin = new Padding(3, 4, 3, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 4, 3, 4);
            groupBox10.Size = new Size(199, 63);
            groupBox10.TabIndex = 3;
            groupBox10.TabStop = false;
            groupBox10.Text = "Nhân Viên";
            // 
            // txtEmpName
            // 
            txtEmpName.AutoSize = true;
            txtEmpName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpName.Location = new Point(35, 27);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(21, 20);
            txtEmpName.TabIndex = 0;
            txtEmpName.Text = "...";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(dtpOrder);
            groupBox11.Location = new Point(246, 93);
            groupBox11.Margin = new Padding(3, 4, 3, 4);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 4, 3, 4);
            groupBox11.Size = new Size(254, 63);
            groupBox11.TabIndex = 4;
            groupBox11.TabStop = false;
            groupBox11.Text = "Ngày lập ";
            // 
            // dtpOrder
            // 
            dtpOrder.Location = new Point(10, 22);
            dtpOrder.Name = "dtpOrder";
            dtpOrder.Size = new Size(238, 27);
            dtpOrder.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cmbCusName);
            groupBox9.Location = new Point(331, 16);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(163, 69);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "Khách hàng";
            // 
            // cmbCusName
            // 
            cmbCusName.FormattingEnabled = true;
            cmbCusName.Location = new Point(14, 25);
            cmbCusName.Margin = new Padding(3, 4, 3, 4);
            cmbCusName.Name = "cmbCusName";
            cmbCusName.Size = new Size(138, 28);
            cmbCusName.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(button1);
            groupBox8.Controls.Add(txtOrderID);
            groupBox8.Location = new Point(7, 16);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(275, 69);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Mã hóa đơn";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(168, 23);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 21;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(21, 29);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(114, 27);
            txtOrderID.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(3, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 74);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(18, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1210, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(198, 25);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 2;
            txtAccName.Text = "Acc Name";
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
            ABC.Location = new Point(549, 18);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // sellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 873);
            Controls.Add(panel1);
            Name = "sellForm";
            Text = "sellForm";
            Load += sellForm_Load;
            panel1.ResumeLayout(false);
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox14.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView lsvOrder;
        private Button btnPay;
        private Button btnCancel;
        private GroupBox groupBox20;
        private Label txtPriceAll;
        private Button btnClear;
        private Button btnAddProduct;
        private GroupBox groupBox1;
        private ListView lsvProduct;
        private GroupBox groupBox2;
        private GroupBox groupBox6;
        private TextBox txtQuantity;
        private GroupBox groupBox5;
        private Label txtPrice;
        private GroupBox groupBox4;
        private Label txtProductName;
        private GroupBox groupBox3;
        private Label txtCateId;
        private GroupBox groupBox13;
        private Label txtProductId;
        private GroupBox groupBox7;
        private GroupBox groupBox12;
        private Label txtPricePro;
        private GroupBox groupBox11;
        private GroupBox groupBox10;
        private Label txtEmpName;
        private GroupBox groupBox9;
        private ComboBox cmbCusName;
        private GroupBox groupBox8;
        private TextBox txtOrderID;
        private Panel panel2;
        private Label txtAccName;
        private Label label1;
        private Label ABC;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DateTimePicker dtpOrder;
        private Button button1;
        private GroupBox groupBox14;
        private ComboBox cboDiscount;
    }
}