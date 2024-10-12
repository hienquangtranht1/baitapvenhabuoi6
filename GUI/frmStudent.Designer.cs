namespace GUI
{
    partial class frmStudent
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
            this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.lbldtb = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.btnaddupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.DGCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpttsv = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.grpttsv.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkUnregisterMajor
            // 
            this.chkUnregisterMajor.AutoSize = true;
            this.chkUnregisterMajor.Location = new System.Drawing.Point(661, 80);
            this.chkUnregisterMajor.Name = "chkUnregisterMajor";
            this.chkUnregisterMajor.Size = new System.Drawing.Size(237, 20);
            this.chkUnregisterMajor.TabIndex = 24;
            this.chkUnregisterMajor.Text = "Sinh viên đăng ký chuyên ngành ck";
            this.chkUnregisterMajor.UseVisualStyleBackColor = true;
            this.chkUnregisterMajor.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(76, 242);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(200, 22);
            this.txtdtb.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(76, 106);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 22);
            this.txthoten.TabIndex = 5;
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(76, 45);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(200, 22);
            this.txtmssv.TabIndex = 4;
            // 
            // lbldtb
            // 
            this.lbldtb.AutoSize = true;
            this.lbldtb.Location = new System.Drawing.Point(26, 248);
            this.lbldtb.Name = "lbldtb";
            this.lbldtb.Size = new System.Drawing.Size(37, 16);
            this.lbldtb.TabIndex = 3;
            this.lbldtb.Text = "ĐTB:";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(26, 176);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(41, 16);
            this.lblkhoa.TabIndex = 2;
            this.lblkhoa.Text = "Khoa:";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(12, 109);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(55, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ Tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(19, 51);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(48, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // btnaddupdate
            // 
            this.btnaddupdate.Location = new System.Drawing.Point(68, 399);
            this.btnaddupdate.Name = "btnaddupdate";
            this.btnaddupdate.Size = new System.Drawing.Size(105, 23);
            this.btnaddupdate.TabIndex = 23;
            this.btnaddupdate.Text = "Add/Update";
            this.btnaddupdate.UseVisualStyleBackColor = true;
            this.btnaddupdate.Click += new System.EventHandler(this.btnaddupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(823, 412);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(275, 399);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(76, 176);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(200, 24);
            this.cbbkhoa.TabIndex = 7;
            // 
            // DGCN
            // 
            this.DGCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGCN.HeaderText = "Chuyên Ngành";
            this.DGCN.MinimumWidth = 6;
            this.DGCN.Name = "DGCN";
            this.DGCN.ReadOnly = true;
            this.DGCN.Width = 124;
            // 
            // DGDTB
            // 
            this.DGDTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGDTB.HeaderText = "DTB";
            this.DGDTB.MinimumWidth = 6;
            this.DGDTB.Name = "DGDTB";
            this.DGDTB.ReadOnly = true;
            this.DGDTB.Width = 64;
            // 
            // DGKHOA
            // 
            this.DGKHOA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGKHOA.HeaderText = "Khoa";
            this.DGKHOA.MinimumWidth = 6;
            this.DGKHOA.Name = "DGKHOA";
            this.DGKHOA.ReadOnly = true;
            this.DGKHOA.Width = 67;
            // 
            // DGHT
            // 
            this.DGHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGHT.HeaderText = "Họ Tên";
            this.DGHT.MinimumWidth = 6;
            this.DGHT.Name = "DGHT";
            this.DGHT.ReadOnly = true;
            this.DGHT.Width = 81;
            // 
            // DGMSSV
            // 
            this.DGMSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGMSSV.HeaderText = "MSSV";
            this.DGMSSV.MinimumWidth = 6;
            this.DGMSSV.Name = "DGMSSV";
            this.DGMSSV.ReadOnly = true;
            this.DGMSSV.Width = 74;
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGMSSV,
            this.DGHT,
            this.DGKHOA,
            this.DGDTB,
            this.DGCN});
            this.dataGV.Location = new System.Drawing.Point(403, 118);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(641, 288);
            this.dataGV.TabIndex = 18;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // grpttsv
            // 
            this.grpttsv.Controls.Add(this.cbbkhoa);
            this.grpttsv.Controls.Add(this.txtdtb);
            this.grpttsv.Controls.Add(this.txthoten);
            this.grpttsv.Controls.Add(this.txtmssv);
            this.grpttsv.Controls.Add(this.lbldtb);
            this.grpttsv.Controls.Add(this.lblkhoa);
            this.grpttsv.Controls.Add(this.lblhoten);
            this.grpttsv.Controls.Add(this.lblMSSV);
            this.grpttsv.Location = new System.Drawing.Point(68, 58);
            this.grpttsv.Name = "grpttsv";
            this.grpttsv.Size = new System.Drawing.Size(282, 324);
            this.grpttsv.TabIndex = 19;
            this.grpttsv.TabStop = false;
            this.grpttsv.Text = "Thông Tin Sinh Viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 507);
            this.Controls.Add(this.chkUnregisterMajor);
            this.Controls.Add(this.btnaddupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.grpttsv);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmStudent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.grpttsv.ResumeLayout(false);
            this.grpttsv.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUnregisterMajor;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Label lbldtb;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Button btnaddupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGKHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGMSSV;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpttsv;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

