namespace QLDuLieuNoiBo.NVCoBan
{
    partial class fKeHoach
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
            this.dgvDSDonVi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSDonVi
            // 
            this.dgvDSDonVi.AllowUserToAddRows = false;
            this.dgvDSDonVi.AllowUserToDeleteRows = false;
            this.dgvDSDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDonVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDonVi.Location = new System.Drawing.Point(3, 26);
            this.dgvDSDonVi.MultiSelect = false;
            this.dgvDSDonVi.Name = "dgvDSDonVi";
            this.dgvDSDonVi.ReadOnly = true;
            this.dgvDSDonVi.RowHeadersWidth = 51;
            this.dgvDSDonVi.RowTemplate.Height = 24;
            this.dgvDSDonVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDonVi.Size = new System.Drawing.Size(908, 344);
            this.dgvDSDonVi.TabIndex = 6;
            // 
            // fKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 396);
            this.Controls.Add(this.dgvDSDonVi);
            this.Name = "fKeHoach";
            this.Text = "fKeHoach";
            this.Load += new System.EventHandler(this.fKeHoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonVi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDonVi;
    }
}