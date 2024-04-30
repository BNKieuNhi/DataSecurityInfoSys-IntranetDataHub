namespace QLDuLieuNoiBo.GiangVien
{
    partial class fPhanCong
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
            this.dgvDSPhanCong.Location = new System.Drawing.Point(3, 26);
            this.dgvDSPhanCong.MultiSelect = false;
            this.dgvDSPhanCong.Name = "dgvDSPhanCong";
            this.dgvDSPhanCong.ReadOnly = true;
            this.dgvDSPhanCong.RowHeadersWidth = 51;
            this.dgvDSPhanCong.RowTemplate.Height = 24;
            this.dgvDSPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhanCong.Size = new System.Drawing.Size(908, 344);
            this.dgvDSPhanCong.TabIndex = 6;
            // 
            // fPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 396);
            this.Controls.Add(this.dgvDSPhanCong);
            this.Name = "fPhanCong";
            this.Text = "fPhanCong";
            this.Load += new System.EventHandler(this.fPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhanCong;
    }
}