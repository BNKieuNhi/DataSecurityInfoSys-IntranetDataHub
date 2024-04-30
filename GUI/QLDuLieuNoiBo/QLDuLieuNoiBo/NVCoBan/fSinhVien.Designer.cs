namespace QLDuLieuNoiBo.NVCoBan
{
    partial class fSinhVien
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
            this.dgvDSSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSinhVien
            // 
            this.dgvDSSinhVien.AllowUserToAddRows = false;
            this.dgvDSSinhVien.AllowUserToDeleteRows = false;
            this.dgvDSSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSinhVien.Location = new System.Drawing.Point(1, 27);
            this.dgvDSSinhVien.MultiSelect = false;
            this.dgvDSSinhVien.Name = "dgvDSSinhVien";
            this.dgvDSSinhVien.ReadOnly = true;
            this.dgvDSSinhVien.RowHeadersWidth = 51;
            this.dgvDSSinhVien.RowTemplate.Height = 24;
            this.dgvDSSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSinhVien.Size = new System.Drawing.Size(908, 355);
            this.dgvDSSinhVien.TabIndex = 4;
            // 
            // fSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 409);
            this.Controls.Add(this.dgvDSSinhVien);
            this.Name = "fSinhVien";
            this.Text = "fSinhVien";
            this.Load += new System.EventHandler(this.fSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSinhVien;
    }
}