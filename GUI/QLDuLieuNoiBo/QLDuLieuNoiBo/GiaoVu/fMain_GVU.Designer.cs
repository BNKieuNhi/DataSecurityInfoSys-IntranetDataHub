namespace QLDuLieuNoiBo.GiaoVu
{
    partial class fMain_GVU
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonViToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeHoachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhanCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KQHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(814, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 27);
            this.panel2.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(45, 2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 22);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(325, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTCaNhanToolStripMenuItem,
            this.SinhVienToolStripMenuItem,
            this.DonViToolStripMenuItem,
            this.HocPhanToolStripMenuItem,
            this.KeHoachToolStripMenuItem,
            this.PhanCongToolStripMenuItem,
            this.KQHPToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // TTCaNhanToolStripMenuItem
            // 
            this.TTCaNhanToolStripMenuItem.Name = "TTCaNhanToolStripMenuItem";
            this.TTCaNhanToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.TTCaNhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.TTCaNhanToolStripMenuItem.Click += new System.EventHandler(this.TTCaNhanToolStripMenuItem_Click);
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.SinhVienToolStripMenuItem.Text = "Sinh viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // DonViToolStripMenuItem
            // 
            this.DonViToolStripMenuItem.Name = "DonViToolStripMenuItem";
            this.DonViToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.DonViToolStripMenuItem.Text = "Đơn vị";
            this.DonViToolStripMenuItem.Click += new System.EventHandler(this.DonViToolStripMenuItem_Click);
            // 
            // HocPhanToolStripMenuItem
            // 
            this.HocPhanToolStripMenuItem.Name = "HocPhanToolStripMenuItem";
            this.HocPhanToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.HocPhanToolStripMenuItem.Text = "Học phần";
            this.HocPhanToolStripMenuItem.Click += new System.EventHandler(this.HocPhanToolStripMenuItem_Click);
            // 
            // KeHoachToolStripMenuItem
            // 
            this.KeHoachToolStripMenuItem.Name = "KeHoachToolStripMenuItem";
            this.KeHoachToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.KeHoachToolStripMenuItem.Text = "Kế hoạch mở môn";
            this.KeHoachToolStripMenuItem.Click += new System.EventHandler(this.KeHoachToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 36);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(972, 517);
            this.pnlContent.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 27);
            this.panel1.TabIndex = 10;
            // 
            // PhanCongToolStripMenuItem
            // 
            this.PhanCongToolStripMenuItem.Name = "PhanCongToolStripMenuItem";
            this.PhanCongToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.PhanCongToolStripMenuItem.Text = "Phân công giảng dạy";
            this.PhanCongToolStripMenuItem.Click += new System.EventHandler(this.PhanCongToolStripMenuItem_Click);
            // 
            // KQHPToolStripMenuItem
            // 
            this.KQHPToolStripMenuItem.Name = "KQHPToolStripMenuItem";
            this.KQHPToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.KQHPToolStripMenuItem.Text = "Kết quả học phần";
            this.KQHPToolStripMenuItem.Click += new System.EventHandler(this.KQHPToolStripMenuItem_Click);
            // 
            // fMain_GVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "fMain_GVU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain_GVU";
            this.Load += new System.EventHandler(this.fMain_GVU_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DonViToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeHoachToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem PhanCongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KQHPToolStripMenuItem;
    }
}