namespace MobileStore.GUI
{
    partial class importForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importForm));
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox2 = new PictureBox();
            picExit = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ABC = new Label();
            panel1 = new Panel();
            lsvImport = new ListView();
            btnExportEcel = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            groupBox14 = new GroupBox();
            groupBox17 = new GroupBox();
            txtContent = new TextBox();
            groupBox18 = new GroupBox();
            cmbTypeSearch = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            panel1.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox18.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(picExit);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 77);
            panel2.TabIndex = 3;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(184, 23);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 17;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(1201, 12);
            picExit.Margin = new Padding(3, 4, 3, 4);
            picExit.Name = "picExit";
            picExit.Size = new Size(41, 51);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 9;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(598, 18);
            label2.Name = "label2";
            label2.Size = new Size(237, 40);
            label2.TabIndex = 0;
            label2.Text = "Alpha Mobile";
            // 
            // ABC
            // 
            ABC.AutoSize = true;
            ABC.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ABC.ForeColor = SystemColors.ActiveCaptionText;
            ABC.Location = new Point(588, 18);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lsvImport);
            panel1.Controls.Add(btnExportEcel);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(groupBox14);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 683);
            panel1.TabIndex = 2;
            // 
            // lsvImport
            // 
            lsvImport.Location = new Point(51, 297);
            lsvImport.Name = "lsvImport";
            lsvImport.Size = new Size(1221, 373);
            lsvImport.TabIndex = 27;
            lsvImport.UseCompatibleStateImageBehavior = false;
            lsvImport.ItemActivate += lsvImport_ItemActivate;
            // 
            // btnExportEcel
            // 
            btnExportEcel.BackColor = Color.Tomato;
            btnExportEcel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportEcel.ForeColor = SystemColors.ControlLightLight;
            btnExportEcel.Location = new Point(827, 175);
            btnExportEcel.Margin = new Padding(3, 4, 3, 4);
            btnExportEcel.Name = "btnExportEcel";
            btnExportEcel.Size = new Size(120, 55);
            btnExportEcel.TabIndex = 26;
            btnExportEcel.Text = "Xuất Excel";
            btnExportEcel.UseVisualStyleBackColor = false;
            btnExportEcel.Click += btnExportEcel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(637, 175);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 55);
            btnClear.TabIndex = 18;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(637, 93);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 55);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(groupBox17);
            groupBox14.Controls.Add(groupBox18);
            groupBox14.Location = new Point(222, 93);
            groupBox14.Margin = new Padding(3, 4, 3, 4);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 4, 3, 4);
            groupBox14.Size = new Size(408, 136);
            groupBox14.TabIndex = 11;
            groupBox14.TabStop = false;
            groupBox14.Text = "Tìm kiếm";
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
            // txtContent
            // 
            txtContent.Location = new Point(27, 24);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(114, 27);
            txtContent.TabIndex = 1;
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
            // cmbTypeSearch
            // 
            cmbTypeSearch.FormattingEnabled = true;
            cmbTypeSearch.Location = new Point(13, 23);
            cmbTypeSearch.Margin = new Padding(3, 4, 3, 4);
            cmbTypeSearch.Name = "cmbTypeSearch";
            cmbTypeSearch.Size = new Size(138, 28);
            cmbTypeSearch.TabIndex = 1;
            // 
            // importForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 683);
            Controls.Add(panel1);
            Name = "importForm";
            Text = "importGUI";
            Load += importForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            panel1.ResumeLayout(false);
            groupBox14.ResumeLayout(false);
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox18.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label ABC;
        private Panel panel1;
        private ListView lsvImport;
        private Button btnExportEcel;
        private Button btnClear;
        private Button btnSearch;
        private GroupBox groupBox14;
        private GroupBox groupBox17;
        private TextBox txtContent;
        private GroupBox groupBox18;
        private ComboBox cmbTypeSearch;
        private PictureBox pictureBox2;
        private PictureBox picExit;
        private Label txtAccName;
        private Label label2;
    }
}