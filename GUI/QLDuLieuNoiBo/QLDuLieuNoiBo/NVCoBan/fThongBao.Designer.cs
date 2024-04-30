namespace QLDuLieuNoiBo.NVCoBan
{
    partial class fThongBao
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
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.AllowUserToAddRows = false;
            this.dgvThongBao.AllowUserToDeleteRows = false;
            this.dgvThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongBao.Location = new System.Drawing.Point(2, 75);
            this.dgvThongBao.MultiSelect = false;
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.ReadOnly = true;
            this.dgvThongBao.RowHeadersWidth = 51;
            this.dgvThongBao.RowTemplate.Height = 24;
            this.dgvThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongBao.Size = new System.Drawing.Size(908, 355);
            this.dgvThongBao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(366, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "THÔNG BÁO";
            // 
            // fThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThongBao);
            this.Name = "fThongBao";
            this.Text = "fThongBao";
            this.Load += new System.EventHandler(this.fThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.Label label2;
    }
}