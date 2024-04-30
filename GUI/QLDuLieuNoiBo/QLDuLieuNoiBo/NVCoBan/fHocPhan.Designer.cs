namespace QLDuLieuNoiBo.NVCoBan
{
    partial class fHocPhan
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.dgvDSDonVi.Location = new System.Drawing.Point(3, 87);
            this.dgvDSDonVi.MultiSelect = false;
            this.dgvDSDonVi.Name = "dgvDSDonVi";
            this.dgvDSDonVi.ReadOnly = true;
            this.dgvDSDonVi.RowHeadersWidth = 51;
            this.dgvDSDonVi.RowTemplate.Height = 24;
            this.dgvDSDonVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDonVi.Size = new System.Drawing.Size(906, 344);
            this.dgvDSDonVi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(307, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "DANH SÁCH HỌC PHẦN";
            // 
            // fHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSDonVi);
            this.Name = "fHocPhan";
            this.Text = "fHocPhan";
            this.Load += new System.EventHandler(this.fHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDonVi;
        private System.Windows.Forms.Label label2;
    }
}