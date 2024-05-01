namespace QLDuLieuNoiBo.GiangVien
{
    partial class fKQHocPhan
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
            this.dgvDSKQHP = new System.Windows.Forms.DataGridView();
            this.txtSinhVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHocPhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.lblDiemQT = new System.Windows.Forms.Label();
            this.txtDiemQT = new System.Windows.Forms.TextBox();
            this.lblDiemCK = new System.Windows.Forms.Label();
            this.txtDiemTH = new System.Windows.Forms.TextBox();
            this.lblDiemTH = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSKQHP
            // 
            this.dgvDSKQHP.AllowUserToAddRows = false;
            this.dgvDSKQHP.AllowUserToDeleteRows = false;
            this.dgvDSKQHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSKQHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKQHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKQHP.Location = new System.Drawing.Point(3, 198);
            this.dgvDSKQHP.MultiSelect = false;
            this.dgvDSKQHP.Name = "dgvDSKQHP";
            this.dgvDSKQHP.ReadOnly = true;
            this.dgvDSKQHP.RowHeadersWidth = 51;
            this.dgvDSKQHP.RowTemplate.Height = 24;
            this.dgvDSKQHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKQHP.Size = new System.Drawing.Size(908, 331);
            this.dgvDSKQHP.TabIndex = 6;
            this.dgvDSKQHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKQHP_CellClick);
            // 
            // txtSinhVien
            // 
            this.txtSinhVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinhVien.Location = new System.Drawing.Point(163, 25);
            this.txtSinhVien.Name = "txtSinhVien";
            this.txtSinhVien.ReadOnly = true;
            this.txtSinhVien.Size = new System.Drawing.Size(165, 30);
            this.txtSinhVien.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sinh viên:";
            // 
            // txtHocPhan
            // 
            this.txtHocPhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhan.Location = new System.Drawing.Point(163, 80);
            this.txtHocPhan.Name = "txtHocPhan";
            this.txtHocPhan.ReadOnly = true;
            this.txtHocPhan.Size = new System.Drawing.Size(165, 30);
            this.txtHocPhan.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(38, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Năm học:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(163, 136);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.ReadOnly = true;
            this.txtNamHoc.Size = new System.Drawing.Size(165, 30);
            this.txtNamHoc.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(38, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Học phần:";
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemCK.Location = new System.Drawing.Point(499, 136);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(165, 30);
            this.txtDiemCK.TabIndex = 66;
            // 
            // lblDiemQT
            // 
            this.lblDiemQT.AutoSize = true;
            this.lblDiemQT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemQT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDiemQT.Location = new System.Drawing.Point(374, 85);
            this.lblDiemQT.Name = "lblDiemQT";
            this.lblDiemQT.Size = new System.Drawing.Size(85, 25);
            this.lblDiemQT.TabIndex = 65;
            this.lblDiemQT.Text = "Điểm QT:";
            // 
            // txtDiemQT
            // 
            this.txtDiemQT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemQT.Location = new System.Drawing.Point(499, 80);
            this.txtDiemQT.Name = "txtDiemQT";
            this.txtDiemQT.Size = new System.Drawing.Size(165, 30);
            this.txtDiemQT.TabIndex = 64;
            // 
            // lblDiemCK
            // 
            this.lblDiemCK.AutoSize = true;
            this.lblDiemCK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemCK.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDiemCK.Location = new System.Drawing.Point(374, 141);
            this.lblDiemCK.Name = "lblDiemCK";
            this.lblDiemCK.Size = new System.Drawing.Size(84, 25);
            this.lblDiemCK.TabIndex = 63;
            this.lblDiemCK.Text = "Điểm CK:";
            // 
            // txtDiemTH
            // 
            this.txtDiemTH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTH.Location = new System.Drawing.Point(499, 25);
            this.txtDiemTH.Name = "txtDiemTH";
            this.txtDiemTH.Size = new System.Drawing.Size(165, 30);
            this.txtDiemTH.TabIndex = 62;
            // 
            // lblDiemTH
            // 
            this.lblDiemTH.AutoSize = true;
            this.lblDiemTH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDiemTH.Location = new System.Drawing.Point(374, 30);
            this.lblDiemTH.Name = "lblDiemTH";
            this.lblDiemTH.Size = new System.Drawing.Size(85, 25);
            this.lblDiemTH.TabIndex = 61;
            this.lblDiemTH.Text = "Điểm TH:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(724, 133);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(135, 33);
            this.btnCapNhat.TabIndex = 67;
            this.btnCapNhat.Text = "Cập phật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // fKQHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtDiemCK);
            this.Controls.Add(this.lblDiemQT);
            this.Controls.Add(this.txtDiemQT);
            this.Controls.Add(this.lblDiemCK);
            this.Controls.Add(this.txtDiemTH);
            this.Controls.Add(this.lblDiemTH);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHocPhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSKQHP);
            this.Name = "fKQHocPhan";
            this.Text = "fKQHocPhan";
            this.Load += new System.EventHandler(this.fKQHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSKQHP;
        private System.Windows.Forms.TextBox txtSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHocPhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemCK;
        private System.Windows.Forms.Label lblDiemQT;
        private System.Windows.Forms.TextBox txtDiemQT;
        private System.Windows.Forms.Label lblDiemCK;
        private System.Windows.Forms.TextBox txtDiemTH;
        private System.Windows.Forms.Label lblDiemTH;
        private System.Windows.Forms.Button btnCapNhat;
    }
}