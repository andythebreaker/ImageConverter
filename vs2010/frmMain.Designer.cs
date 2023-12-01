namespace ImageConverter
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chkSimple = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.chkTrim = new System.Windows.Forms.CheckBox();
            this.chkSharpen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOutputFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubFolder = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.rotate_group = new System.Windows.Forms.GroupBox();
            this.r0 = new System.Windows.Forms.RadioButton();
            this.r90 = new System.Windows.Forms.RadioButton();
            this.rccw90 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rotate_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(621, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(29, 22);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(104, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Job Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(29, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(518, 208);
            this.listBox1.TabIndex = 1;
            // 
            // chkSimple
            // 
            this.chkSimple.AutoSize = true;
            this.chkSimple.Checked = true;
            this.chkSimple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSimple.Location = new System.Drawing.Point(29, 290);
            this.chkSimple.Name = "chkSimple";
            this.chkSimple.Size = new System.Drawing.Size(86, 16);
            this.chkSimple.TabIndex = 4;
            this.chkSimple.Text = "Simple Select";
            this.chkSimple.UseVisualStyleBackColor = true;
            this.chkSimple.Click += new System.EventHandler(this.chkSimple_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(581, 293);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(116, 25);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtQuality);
            this.groupBox1.Controls.Add(this.chkTrim);
            this.groupBox1.Controls.Add(this.chkSharpen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDensity);
            this.groupBox1.Location = new System.Drawing.Point(28, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 164);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Options";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Aditional Conversion Options";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(80, 59);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(74, 22);
            this.txtQuality.TabIndex = 1;
            this.txtQuality.Text = "100";
            this.txtQuality.TextChanged += new System.EventHandler(this.txtQuality_TextChanged);
            // 
            // chkTrim
            // 
            this.chkTrim.AutoSize = true;
            this.chkTrim.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTrim.Location = new System.Drawing.Point(108, 91);
            this.chkTrim.Name = "chkTrim";
            this.chkTrim.Size = new System.Drawing.Size(47, 16);
            this.chkTrim.TabIndex = 3;
            this.chkTrim.Text = "Trim";
            this.chkTrim.UseVisualStyleBackColor = true;
            // 
            // chkSharpen
            // 
            this.chkSharpen.AutoSize = true;
            this.chkSharpen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSharpen.Checked = true;
            this.chkSharpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSharpen.Location = new System.Drawing.Point(27, 91);
            this.chkSharpen.Name = "chkSharpen";
            this.chkSharpen.Size = new System.Drawing.Size(62, 16);
            this.chkSharpen.TabIndex = 2;
            this.chkSharpen.Text = "Sharpen";
            this.chkSharpen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quality:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Density:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDensity
            // 
            this.txtDensity.Location = new System.Drawing.Point(80, 27);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(74, 22);
            this.txtDensity.TabIndex = 0;
            this.txtDensity.Text = "150";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(156, 293);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(69, 24);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbOutputFormat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSubFolder);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Location = new System.Drawing.Point(240, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 163);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Format";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(21, 138);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(41, 12);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Outputs";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Formats";
            // 
            // cmbOutputFormat
            // 
            this.cmbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutputFormat.FormattingEnabled = true;
            this.cmbOutputFormat.ItemHeight = 12;
            this.cmbOutputFormat.Items.AddRange(new object[] {
            "BMP",
            "GIF",
            "JPEG",
            "PDF",
            "PNG",
            "TIFF",
            "jpg"});
            this.cmbOutputFormat.Location = new System.Drawing.Point(24, 27);
            this.cmbOutputFormat.Name = "cmbOutputFormat";
            this.cmbOutputFormat.Size = new System.Drawing.Size(81, 20);
            this.cmbOutputFormat.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Output Subfolder";
            // 
            // txtSubFolder
            // 
            this.txtSubFolder.Location = new System.Drawing.Point(24, 78);
            this.txtSubFolder.Name = "txtSubFolder";
            this.txtSubFolder.Size = new System.Drawing.Size(130, 22);
            this.txtSubFolder.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(21, 124);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(34, 12);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Inputs";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // rotate_group
            // 
            this.rotate_group.Controls.Add(this.rccw90);
            this.rotate_group.Controls.Add(this.r90);
            this.rotate_group.Controls.Add(this.r0);
            this.rotate_group.Location = new System.Drawing.Point(439, 325);
            this.rotate_group.Name = "rotate_group";
            this.rotate_group.Size = new System.Drawing.Size(138, 163);
            this.rotate_group.TabIndex = 20;
            this.rotate_group.TabStop = false;
            this.rotate_group.Text = "Rotate";
            this.rotate_group.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // r0
            // 
            this.r0.AutoSize = true;
            this.r0.Checked = true;
            this.r0.Location = new System.Drawing.Point(6, 21);
            this.r0.Name = "r0";
            this.r0.Size = new System.Drawing.Size(64, 16);
            this.r0.TabIndex = 0;
            this.r0.TabStop = true;
            this.r0.Text = "no rotate";
            this.r0.UseVisualStyleBackColor = true;
            this.r0.CheckedChanged += new System.EventHandler(this.r0_CheckedChanged);
            // 
            // r90
            // 
            this.r90.AutoSize = true;
            this.r90.Location = new System.Drawing.Point(6, 44);
            this.r90.Name = "r90";
            this.r90.Size = new System.Drawing.Size(57, 16);
            this.r90.TabIndex = 1;
            this.r90.TabStop = true;
            this.r90.Text = "CW 90";
            this.r90.UseVisualStyleBackColor = true;
            this.r90.CheckedChanged += new System.EventHandler(this.r90_CheckedChanged);
            // 
            // rccw90
            // 
            this.rccw90.AutoSize = true;
            this.rccw90.Location = new System.Drawing.Point(6, 66);
            this.rccw90.Name = "rccw90";
            this.rccw90.Size = new System.Drawing.Size(62, 16);
            this.rccw90.TabIndex = 2;
            this.rccw90.TabStop = true;
            this.rccw90.Text = "CCW90";
            this.rccw90.UseVisualStyleBackColor = true;
            this.rccw90.CheckedChanged += new System.EventHandler(this.rccw90_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 507);
            this.Controls.Add(this.rotate_group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.chkSimple);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.Text = "Image Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.rotate_group.ResumeLayout(false);
            this.rotate_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chkSimple;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.CheckBox chkTrim;
        private System.Windows.Forms.CheckBox chkSharpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubFolder;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOutputFormat;
        private System.Windows.Forms.GroupBox rotate_group;
        private System.Windows.Forms.RadioButton r90;
        private System.Windows.Forms.RadioButton r0;
        private System.Windows.Forms.RadioButton rccw90;
    }
}

