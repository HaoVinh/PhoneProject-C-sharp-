namespace MobileStore.GUI
{
    partial class reportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportForm));
            tabControl1 = new TabControl();
            import = new TabPage();
            tableImportReport = new DataGridView();
            groupBox2 = new GroupBox();
            btnRefesh = new Button();
            ImportDateFormat = new ComboBox();
            exportExcel = new Button();
            dataGridView1 = new DataGridView();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            btnSearch = new Button();
            cbxSearch = new ComboBox();
            searchValue = new TextBox();
            sell = new TabPage();
            tableSellReport = new DataGridView();
            groupBox1 = new GroupBox();
            txtSellRefesh = new Button();
            sellCbxDateFormat = new ComboBox();
            exportExcelSell = new Button();
            dtpEndSell = new DateTimePicker();
            dtpStartSell = new DateTimePicker();
            btnSellSearch = new Button();
            cbxSellSearch = new ComboBox();
            sellSearch = new TextBox();
            totalPage = new TabPage();
            panel7 = new Panel();
            pictureBox8 = new PictureBox();
            txtTotalOrder = new Label();
            label4 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            txtTotalSupplier = new Label();
            label11 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            txtTotalImport = new Label();
            label7 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            txtTotalCustomer = new Label();
            customer = new Label();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            txtTotalProduct = new Label();
            cake = new Label();
            panel1 = new Panel();
            txtTotalEmployee = new Label();
            label2 = new Label();
            pictureBox7 = new PictureBox();
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ABC = new Label();
            tabControl1.SuspendLayout();
            import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableImportReport).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableSellReport).BeginInit();
            groupBox1.SuspendLayout();
            totalPage.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(import);
            tabControl1.Controls.Add(sell);
            tabControl1.Controls.Add(totalPage);
            tabControl1.Location = new Point(-5, 101);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1302, 640);
            tabControl1.TabIndex = 4;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // import
            // 
            import.Controls.Add(tableImportReport);
            import.Controls.Add(groupBox2);
            import.ImageIndex = 1;
            import.Location = new Point(4, 29);
            import.Margin = new Padding(3, 4, 3, 4);
            import.Name = "import";
            import.Padding = new Padding(3, 4, 3, 4);
            import.Size = new Size(1294, 607);
            import.TabIndex = 1;
            import.Text = "Nhập Hàng";
            import.UseVisualStyleBackColor = true;
            // 
            // tableImportReport
            // 
            tableImportReport.AllowUserToAddRows = false;
            tableImportReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableImportReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportReport.Location = new Point(0, 150);
            tableImportReport.Margin = new Padding(3, 4, 3, 4);
            tableImportReport.Name = "tableImportReport";
            tableImportReport.RowHeadersWidth = 51;
            tableImportReport.RowTemplate.Height = 25;
            tableImportReport.Size = new Size(1261, 453);
            tableImportReport.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefesh);
            groupBox2.Controls.Add(ImportDateFormat);
            groupBox2.Controls.Add(exportExcel);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(dtpEnd);
            groupBox2.Controls.Add(dtpStart);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(cbxSearch);
            groupBox2.Controls.Add(searchValue);
            groupBox2.Location = new Point(3, 7);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(1252, 136);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnRefesh
            // 
            btnRefesh.BackColor = Color.Tomato;
            btnRefesh.ForeColor = Color.White;
            btnRefesh.Location = new Point(878, 19);
            btnRefesh.Margin = new Padding(2, 3, 2, 3);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(106, 43);
            btnRefesh.TabIndex = 15;
            btnRefesh.Text = "Làm mới";
            btnRefesh.UseVisualStyleBackColor = false;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // ImportDateFormat
            // 
            ImportDateFormat.FormattingEnabled = true;
            ImportDateFormat.Location = new Point(794, 27);
            ImportDateFormat.Margin = new Padding(2, 3, 2, 3);
            ImportDateFormat.Name = "ImportDateFormat";
            ImportDateFormat.Size = new Size(65, 28);
            ImportDateFormat.TabIndex = 14;
            // 
            // exportExcel
            // 
            exportExcel.BackColor = Color.Tomato;
            exportExcel.ForeColor = Color.White;
            exportExcel.Location = new Point(992, 68);
            exportExcel.Margin = new Padding(2, 3, 2, 3);
            exportExcel.Name = "exportExcel";
            exportExcel.Size = new Size(121, 47);
            exportExcel.TabIndex = 12;
            exportExcel.Text = "Xuất excel";
            exportExcel.UseVisualStyleBackColor = false;
            exportExcel.Click += exportExcel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1137, 133);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(274, 200);
            dataGridView1.TabIndex = 11;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(406, 76);
            dtpEnd.Margin = new Padding(3, 4, 3, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(238, 27);
            dtpEnd.TabIndex = 10;
            dtpEnd.Value = new DateTime(2022, 11, 11, 13, 10, 16, 0);
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(107, 77);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(249, 27);
            dtpStart.TabIndex = 9;
            dtpStart.Value = new DateTime(2022, 1, 1, 15, 31, 0, 0);
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(684, 71);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 43);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbxSearch
            // 
            cbxSearch.FormattingEnabled = true;
            cbxSearch.Location = new Point(144, 27);
            cbxSearch.Margin = new Padding(2, 3, 2, 3);
            cbxSearch.Name = "cbxSearch";
            cbxSearch.Size = new Size(119, 28);
            cbxSearch.TabIndex = 6;
            // 
            // searchValue
            // 
            searchValue.Location = new Point(291, 27);
            searchValue.Margin = new Padding(2, 3, 2, 3);
            searchValue.Name = "searchValue";
            searchValue.Size = new Size(498, 27);
            searchValue.TabIndex = 7;
            // 
            // sell
            // 
            sell.Controls.Add(tableSellReport);
            sell.Controls.Add(groupBox1);
            sell.ImageIndex = 2;
            sell.Location = new Point(4, 29);
            sell.Margin = new Padding(3, 4, 3, 4);
            sell.Name = "sell";
            sell.Padding = new Padding(3, 4, 3, 4);
            sell.Size = new Size(1294, 607);
            sell.TabIndex = 2;
            sell.Text = "Bán Hàng";
            sell.UseVisualStyleBackColor = true;
            // 
            // tableSellReport
            // 
            tableSellReport.AllowUserToAddRows = false;
            tableSellReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSellReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSellReport.Location = new Point(3, 150);
            tableSellReport.Margin = new Padding(3, 4, 3, 4);
            tableSellReport.Name = "tableSellReport";
            tableSellReport.RowHeadersWidth = 51;
            tableSellReport.RowTemplate.Height = 25;
            tableSellReport.Size = new Size(1247, 457);
            tableSellReport.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSellRefesh);
            groupBox1.Controls.Add(sellCbxDateFormat);
            groupBox1.Controls.Add(exportExcelSell);
            groupBox1.Controls.Add(dtpEndSell);
            groupBox1.Controls.Add(dtpStartSell);
            groupBox1.Controls.Add(btnSellSearch);
            groupBox1.Controls.Add(cbxSellSearch);
            groupBox1.Controls.Add(sellSearch);
            groupBox1.Location = new Point(2, 7);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(1249, 136);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtSellRefesh
            // 
            txtSellRefesh.BackColor = Color.Tomato;
            txtSellRefesh.ForeColor = Color.White;
            txtSellRefesh.Location = new Point(918, 19);
            txtSellRefesh.Margin = new Padding(2, 3, 2, 3);
            txtSellRefesh.Name = "txtSellRefesh";
            txtSellRefesh.Size = new Size(106, 43);
            txtSellRefesh.TabIndex = 16;
            txtSellRefesh.Text = "Làm mới";
            txtSellRefesh.UseVisualStyleBackColor = false;
            txtSellRefesh.Click += btnSellRefesh_Click;
            // 
            // sellCbxDateFormat
            // 
            sellCbxDateFormat.FormattingEnabled = true;
            sellCbxDateFormat.Location = new Point(799, 27);
            sellCbxDateFormat.Margin = new Padding(2, 3, 2, 3);
            sellCbxDateFormat.Name = "sellCbxDateFormat";
            sellCbxDateFormat.Size = new Size(65, 28);
            sellCbxDateFormat.TabIndex = 15;
            // 
            // exportExcelSell
            // 
            exportExcelSell.BackColor = Color.Tomato;
            exportExcelSell.ForeColor = Color.White;
            exportExcelSell.Location = new Point(994, 81);
            exportExcelSell.Margin = new Padding(2, 3, 2, 3);
            exportExcelSell.Name = "exportExcelSell";
            exportExcelSell.Size = new Size(121, 43);
            exportExcelSell.TabIndex = 13;
            exportExcelSell.Text = "Xuất Excel";
            exportExcelSell.UseVisualStyleBackColor = false;
            exportExcelSell.Click += exportExcelSell_Click;
            // 
            // dtpEndSell
            // 
            dtpEndSell.Location = new Point(409, 85);
            dtpEndSell.Margin = new Padding(3, 4, 3, 4);
            dtpEndSell.Name = "dtpEndSell";
            dtpEndSell.Size = new Size(242, 27);
            dtpEndSell.TabIndex = 10;
            // 
            // dtpStartSell
            // 
            dtpStartSell.Location = new Point(123, 85);
            dtpStartSell.Margin = new Padding(3, 4, 3, 4);
            dtpStartSell.Name = "dtpStartSell";
            dtpStartSell.Size = new Size(244, 27);
            dtpStartSell.TabIndex = 9;
            dtpStartSell.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // btnSellSearch
            // 
            btnSellSearch.BackColor = Color.Tomato;
            btnSellSearch.ForeColor = Color.White;
            btnSellSearch.Location = new Point(688, 81);
            btnSellSearch.Margin = new Padding(2, 3, 2, 3);
            btnSellSearch.Name = "btnSellSearch";
            btnSellSearch.Size = new Size(194, 43);
            btnSellSearch.TabIndex = 8;
            btnSellSearch.Text = "Tìm Kiếm";
            btnSellSearch.UseVisualStyleBackColor = false;
            btnSellSearch.Click += btnSellSearch_Click;
            // 
            // cbxSellSearch
            // 
            cbxSellSearch.FormattingEnabled = true;
            cbxSellSearch.Location = new Point(151, 27);
            cbxSellSearch.Margin = new Padding(2, 3, 2, 3);
            cbxSellSearch.Name = "cbxSellSearch";
            cbxSellSearch.Size = new Size(119, 28);
            cbxSellSearch.TabIndex = 6;
            // 
            // sellSearch
            // 
            sellSearch.Location = new Point(306, 27);
            sellSearch.Margin = new Padding(2, 3, 2, 3);
            sellSearch.Name = "sellSearch";
            sellSearch.Size = new Size(487, 27);
            sellSearch.TabIndex = 7;
            // 
            // totalPage
            // 
            totalPage.Controls.Add(panel7);
            totalPage.Controls.Add(panel6);
            totalPage.Controls.Add(panel4);
            totalPage.Controls.Add(panel3);
            totalPage.Controls.Add(panel5);
            totalPage.Controls.Add(panel1);
            totalPage.Location = new Point(4, 29);
            totalPage.Name = "totalPage";
            totalPage.Size = new Size(1294, 607);
            totalPage.TabIndex = 3;
            totalPage.Text = "Tổng quan";
            totalPage.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 192, 128);
            panel7.Controls.Add(pictureBox8);
            panel7.Controls.Add(txtTotalOrder);
            panel7.Controls.Add(label4);
            panel7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(681, 232);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(235, 164);
            panel7.TabIndex = 12;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.bill;
            pictureBox8.Location = new Point(14, 24);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(73, 108);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            // 
            // txtTotalOrder
            // 
            txtTotalOrder.AutoSize = true;
            txtTotalOrder.Location = new Point(150, 99);
            txtTotalOrder.Name = "txtTotalOrder";
            txtTotalOrder.Size = new Size(25, 30);
            txtTotalOrder.TabIndex = 2;
            txtTotalOrder.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(117, 24);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 1;
            label4.Text = "Đơn bán";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 192, 128);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(txtTotalSupplier);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(840, 437);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(254, 164);
            panel6.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.supplier;
            pictureBox3.Location = new Point(14, 24);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // txtTotalSupplier
            // 
            txtTotalSupplier.AutoSize = true;
            txtTotalSupplier.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalSupplier.Location = new Point(135, 99);
            txtTotalSupplier.Name = "txtTotalSupplier";
            txtTotalSupplier.Size = new Size(25, 30);
            txtTotalSupplier.TabIndex = 2;
            txtTotalSupplier.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(88, 29);
            label11.Name = "label11";
            label11.Size = new Size(152, 24);
            label11.TabIndex = 1;
            label11.Text = "Nhà Cung Cấp";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(txtTotalImport);
            panel4.Controls.Add(label7);
            panel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(233, 232);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 164);
            panel4.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.importbill;
            pictureBox4.Location = new Point(14, 24);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 108);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // txtTotalImport
            // 
            txtTotalImport.AutoSize = true;
            txtTotalImport.Location = new Point(150, 99);
            txtTotalImport.Name = "txtTotalImport";
            txtTotalImport.Size = new Size(25, 30);
            txtTotalImport.TabIndex = 2;
            txtTotalImport.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(117, 24);
            label7.Name = "label7";
            label7.Size = new Size(107, 24);
            label7.TabIndex = 1;
            label7.Text = "Đơn nhập";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(txtTotalCustomer);
            panel3.Controls.Add(customer);
            panel3.Location = new Point(840, 13);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 164);
            panel3.TabIndex = 8;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.customer;
            pictureBox5.Location = new Point(14, 24);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 108);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // txtTotalCustomer
            // 
            txtTotalCustomer.AutoSize = true;
            txtTotalCustomer.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalCustomer.Location = new Point(147, 99);
            txtTotalCustomer.Name = "txtTotalCustomer";
            txtTotalCustomer.Size = new Size(25, 30);
            txtTotalCustomer.TabIndex = 2;
            txtTotalCustomer.Text = "0";
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            customer.Location = new Point(109, 24);
            customer.Name = "customer";
            customer.Size = new Size(132, 24);
            customer.TabIndex = 1;
            customer.Text = "Khách Hàng";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(txtTotalProduct);
            panel5.Controls.Add(cake);
            panel5.Location = new Point(38, 437);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 164);
            panel5.TabIndex = 9;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.phone;
            pictureBox6.Location = new Point(16, 24);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 108);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // txtTotalProduct
            // 
            txtTotalProduct.AutoSize = true;
            txtTotalProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalProduct.Location = new Point(143, 99);
            txtTotalProduct.Name = "txtTotalProduct";
            txtTotalProduct.Size = new Size(25, 30);
            txtTotalProduct.TabIndex = 2;
            txtTotalProduct.Text = "0";
            // 
            // cake
            // 
            cake.AutoSize = true;
            cake.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cake.Location = new Point(113, 29);
            cake.Name = "cake";
            cake.Size = new Size(111, 24);
            cake.TabIndex = 1;
            cake.Text = "Sản phẩm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(txtTotalEmployee);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox7);
            panel1.Location = new Point(43, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 164);
            panel1.TabIndex = 7;
            // 
            // txtTotalEmployee
            // 
            txtTotalEmployee.AutoSize = true;
            txtTotalEmployee.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalEmployee.Location = new Point(143, 99);
            txtTotalEmployee.Name = "txtTotalEmployee";
            txtTotalEmployee.Size = new Size(25, 30);
            txtTotalEmployee.TabIndex = 2;
            txtTotalEmployee.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(113, 24);
            label2.Name = "label2";
            label2.Size = new Size(114, 24);
            label2.TabIndex = 1;
            label2.Text = "Nhân Viên";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.employee;
            pictureBox7.Location = new Point(16, 24);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 108);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(-5, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 78);
            panel2.TabIndex = 21;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(201, 23);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 22;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(21, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1221, 14);
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
            ABC.Location = new Point(581, 16);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // reportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 736);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Name = "reportForm";
            Text = "reportForm";
            Load += reportForm_Load;
            tabControl1.ResumeLayout(false);
            import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableImportReport).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableSellReport).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            totalPage.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage import;
        private DataGridView tableImportReport;
        private GroupBox groupBox2;
        private ComboBox ImportDateFormat;
        private Button exportExcel;
        private DataGridView dataGridView1;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private TextBox searchValue;
        private TabPage sell;
        private DataGridView tableSellReport;
        private GroupBox groupBox1;
        private ComboBox sellCbxDateFormat;
        private Button exportExcelSell;
        private DateTimePicker dtpEndSell;
        private DateTimePicker dtpStartSell;
        private Button btnSellSearch;
        private ComboBox cbxSellSearch;
        private TextBox sellSearch;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label ABC;
        private Button btnRefesh;
        private Button txtSellRefesh;
        private TabPage totalPage;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label txtTotalSupplier;
        private Label label11;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label txtTotalImport;
        private Label label7;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Label txtTotalCustomer;
        private Label customer;
        private Panel panel5;
        private PictureBox pictureBox6;
        private Label txtTotalProduct;
        private Label cake;
        private Panel panel1;
        private Label txtTotalEmployee;
        private Label label2;
        private PictureBox pictureBox7;
        private Panel panel7;
        private PictureBox pictureBox8;
        private Label txtTotalOrder;
        private Label label4;
        private Label txtAccName;
    }
}