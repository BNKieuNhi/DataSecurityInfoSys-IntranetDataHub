namespace QLDuLieuNoiBo.GiangVien
{
    partial class fTTSinhVien
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
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDTBTL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTCTL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.cbBoxPhai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBoxChuongTrinh = new System.Windows.Forms.ComboBox();
            this.cbBoxNganh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(193, 242);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(275, 30);
            this.txtSdt.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(46, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtDTBTL
            // 
            this.txtDTBTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDTBTL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTBTL.Location = new System.Drawing.Point(690, 242);
            this.txtDTBTL.Name = "txtDTBTL";
            this.txtDTBTL.Size = new System.Drawing.Size(256, 30);
            this.txtDTBTL.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(516, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "Ngành:";
            // 
            // txtTCTL
            // 
            this.txtTCTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTCTL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCTL.Location = new System.Drawing.Point(690, 191);
            this.txtTCTL.Name = "txtTCTL";
            this.txtTCTL.Size = new System.Drawing.Size(256, 30);
            this.txtTCTL.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(516, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Chương trình:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Phái:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(46, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(193, 92);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(275, 30);
            this.txtHoTen.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(346, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 31);
            this.label2.TabIndex = 60;
            this.label2.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // cbBoxPhai
            // 
            this.cbBoxPhai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBoxPhai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxPhai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxPhai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxPhai.FormattingEnabled = true;
            this.cbBoxPhai.Location = new System.Drawing.Point(193, 191);
            this.cbBoxPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxPhai.Name = "cbBoxPhai";
            this.cbBoxPhai.Size = new System.Drawing.Size(275, 31);
            this.cbBoxPhai.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(51, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 75;
            this.label8.Text = "Địa chỉ:";
            // 
            // cbBoxChuongTrinh
            // 
            this.cbBoxChuongTrinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBoxChuongTrinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxChuongTrinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxChuongTrinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxChuongTrinh.FormattingEnabled = true;
            this.cbBoxChuongTrinh.Location = new System.Drawing.Point(690, 91);
            this.cbBoxChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxChuongTrinh.Name = "cbBoxChuongTrinh";
            this.cbBoxChuongTrinh.Size = new System.Drawing.Size(256, 31);
            this.cbBoxChuongTrinh.TabIndex = 78;
            // 
            // cbBoxNganh
            // 
            this.cbBoxNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBoxNganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxNganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxNganh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxNganh.FormattingEnabled = true;
            this.cbBoxNganh.Location = new System.Drawing.Point(690, 141);
            this.cbBoxNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxNganh.Name = "cbBoxNganh";
            this.cbBoxNganh.Size = new System.Drawing.Size(256, 31);
            this.cbBoxNganh.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(516, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Số TC tích lũy:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(516, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "Điểm TB tích lũy:";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(353, 361);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 33);
            this.btnLuu.TabIndex = 84;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(489, 361);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 33);
            this.btnHuy.TabIndex = 83;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // mtbNgaySinh
            // 
            this.mtbNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbNgaySinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNgaySinh.Location = new System.Drawing.Point(193, 141);
            this.mtbNgaySinh.Mask = "00/00/0000";
            this.mtbNgaySinh.Name = "mtbNgaySinh";
            this.mtbNgaySinh.Size = new System.Drawing.Size(138, 30);
            this.mtbNgaySinh.TabIndex = 85;
            this.mtbNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(193, 141);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(275, 30);
            this.txtNgaySinh.TabIndex = 86;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(193, 297);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(753, 30);
            this.txtDiaChi.TabIndex = 87;
            // 
            // fTTSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 434);
            this.Controls.Add(this.mtbNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbBoxNganh);
            this.Controls.Add(this.cbBoxChuongTrinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBoxPhai);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDTBTL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTCTL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgaySinh);
            this.Name = "fTTSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fTTSinhVien";
            this.Load += new System.EventHandler(this.fTTSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDTBTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTCTL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.ComboBox cbBoxPhai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBoxChuongTrinh;
        private System.Windows.Forms.ComboBox cbBoxNganh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}