namespace QLDuLieuNoiBo.GiaoVu
{
    partial class fKQHocPhan_GVU
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
            this.dgvDSKQHP.Location = new System.Drawing.Point(3, 221);
            this.dgvDSKQHP.MultiSelect = false;
            this.dgvDSKQHP.Name = "dgvDSKQHP";
            this.dgvDSKQHP.ReadOnly = true;
            this.dgvDSKQHP.RowHeadersWidth = 51;
            this.dgvDSKQHP.RowTemplate.Height = 24;
            this.dgvDSKQHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKQHP.Size = new System.Drawing.Size(908, 331);
            this.dgvDSKQHP.TabIndex = 7;
            this.dgvDSKQHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKQHP_CellClick);
            // 
            // fKQHocPhan_GVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.dgvDSKQHP);
            this.Name = "fKQHocPhan_GVU";
            this.Text = "fKHHocPhan_GVU";
            this.Load += new System.EventHandler(this.fKQHocPhan_GVU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSKQHP;
    }
}