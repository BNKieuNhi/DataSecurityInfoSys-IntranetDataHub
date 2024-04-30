namespace QLDuLieuNoiBo.TruongDonVi
{
    partial class fHocPhan_TDV
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
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMahp = new System.Windows.Forms.TextBox();
            this.lblMahp = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkBoxTrgHP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AllowUserToAddRows = false;
            this.dgvHocPhan.AllowUserToDeleteRows = false;
            this.dgvHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Location = new System.Drawing.Point(2, 125);
            this.dgvHocPhan.MultiSelect = false;
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.ReadOnly = true;
            this.dgvHocPhan.RowHeadersWidth = 51;
            this.dgvHocPhan.RowTemplate.Height = 24;
            this.dgvHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocPhan.Size = new System.Drawing.Size(908, 355);
            this.dgvHocPhan.TabIndex = 27;
            this.dgvHocPhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellDoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(544, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 33);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(111, 23);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(313, 31);
            this.txtKeyword.TabIndex = 25;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(25, 26);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(80, 25);
            this.lblKeyword.TabIndex = 24;
            this.lblKeyword.Text = "Từ khóa:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(440, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 33);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(648, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMahp
            // 
            this.txtMahp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahp.Location = new System.Drawing.Point(111, 70);
            this.txtMahp.Name = "txtMahp";
            this.txtMahp.Size = new System.Drawing.Size(147, 31);
            this.txtMahp.TabIndex = 30;
            // 
            // lblMahp
            // 
            this.lblMahp.AutoSize = true;
            this.lblMahp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahp.Location = new System.Drawing.Point(25, 73);
            this.lblMahp.Name = "lblMahp";
            this.lblMahp.Size = new System.Drawing.Size(69, 25);
            this.lblMahp.TabIndex = 31;
            this.lblMahp.Text = "Mã HP:";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Moccasin;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(268, 70);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(77, 33);
            this.btnRecord.TabIndex = 33;
            this.btnRecord.Text = "Ghi";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(353, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 33);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkBoxTrgHP
            // 
            this.chkBoxTrgHP.AutoSize = true;
            this.chkBoxTrgHP.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxTrgHP.Location = new System.Drawing.Point(770, 30);
            this.chkBoxTrgHP.Name = "chkBoxTrgHP";
            this.chkBoxTrgHP.Size = new System.Drawing.Size(130, 21);
            this.chkBoxTrgHP.TabIndex = 34;
            this.chkBoxTrgHP.Text = "Trưởng học phần";
            this.chkBoxTrgHP.UseVisualStyleBackColor = true;
            this.chkBoxTrgHP.Click += new System.EventHandler(this.chkBoxTrgHP_Click);
            // 
            // fHocPhan_TDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 501);
            this.Controls.Add(this.chkBoxTrgHP);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMahp);
            this.Controls.Add(this.txtMahp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvHocPhan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.btnSearch);
            this.Name = "fHocPhan_TDV";
            this.Text = "fHocPhan_TDV";
            this.Load += new System.EventHandler(this.fHocPhan_TDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMahp;
        private System.Windows.Forms.Label lblMahp;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkBoxTrgHP;
    }
}