namespace QLDuLieuNoiBo.GiaoVu
{
    partial class fPhanCong_GVU
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
            this.dgvDSPhanCong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPhanCong
            // 
            this.dgvDSPhanCong.AllowUserToAddRows = false;
            this.dgvDSPhanCong.AllowUserToDeleteRows = false;
            this.dgvDSPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhanCong.Location = new System.Drawing.Point(3, 87);
            this.dgvDSPhanCong.MultiSelect = false;
            this.dgvDSPhanCong.Name = "dgvDSPhanCong";
            this.dgvDSPhanCong.ReadOnly = true;
            this.dgvDSPhanCong.RowHeadersWidth = 51;
            this.dgvDSPhanCong.RowTemplate.Height = 24;
            this.dgvDSPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhanCong.Size = new System.Drawing.Size(906, 344);
            this.dgvDSPhanCong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(312, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "PHÂN CÔNG GIẢNG DẠY";
            // 
            // fPhanCong_GVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSPhanCong);
            this.Name = "fPhanCong_GVU";
            this.Text = "fPhanCong";
            this.Load += new System.EventHandler(this.fPhanCong_GVU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhanCong;
        private System.Windows.Forms.Label label2;
    }
}