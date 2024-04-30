namespace QLDuLieuNoiBo.GiaoVu
{
    partial class fDonVi_GVU
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
            this.gboxAction = new System.Windows.Forms.GroupBox();
            this.cbBoxTrgDonVi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDonVi = new System.Windows.Forms.DataGridView();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gboxAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxAction
            // 
            this.gboxAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAction.Controls.Add(this.cbBoxTrgDonVi);
            this.gboxAction.Controls.Add(this.label1);
            this.gboxAction.Controls.Add(this.txtTenDonVi);
            this.gboxAction.Controls.Add(this.lblKeyword);
            this.gboxAction.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxAction.Location = new System.Drawing.Point(12, 13);
            this.gboxAction.Name = "gboxAction";
            this.gboxAction.Size = new System.Drawing.Size(888, 87);
            this.gboxAction.TabIndex = 39;
            this.gboxAction.TabStop = false;
            this.gboxAction.Text = "Thông tin";
            // 
            // cbBoxTrgDonVi
            // 
            this.cbBoxTrgDonVi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBoxTrgDonVi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxTrgDonVi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxTrgDonVi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTrgDonVi.FormattingEnabled = true;
            this.cbBoxTrgDonVi.Location = new System.Drawing.Point(614, 40);
            this.cbBoxTrgDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxTrgDonVi.Name = "cbBoxTrgDonVi";
            this.cbBoxTrgDonVi.Size = new System.Drawing.Size(241, 31);
            this.cbBoxTrgDonVi.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Trưởng đơn vị:";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDonVi.Location = new System.Drawing.Point(132, 38);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(314, 31);
            this.txtTenDonVi.TabIndex = 41;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(20, 41);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(97, 25);
            this.lblKeyword.TabIndex = 40;
            this.lblKeyword.Text = "Tên đơn vị:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(144, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 33);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDonVi
            // 
            this.dgvDonVi.AllowUserToAddRows = false;
            this.dgvDonVi.AllowUserToDeleteRows = false;
            this.dgvDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonVi.Location = new System.Drawing.Point(2, 173);
            this.dgvDonVi.MultiSelect = false;
            this.dgvDonVi.Name = "dgvDonVi";
            this.dgvDonVi.ReadOnly = true;
            this.dgvDonVi.RowHeadersWidth = 51;
            this.dgvDonVi.RowTemplate.Height = 24;
            this.dgvDonVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonVi.Size = new System.Drawing.Size(908, 366);
            this.dgvDonVi.TabIndex = 43;
            this.dgvDonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonVi_CellClick);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.BackColor = System.Drawing.Color.Moccasin;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(665, 115);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(98, 33);
            this.btnRecord.TabIndex = 46;
            this.btnRecord.Text = "Ghi";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(769, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 33);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(257, 115);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 33);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // fDonVi_GVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 539);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvDonVi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gboxAction);
            this.Name = "fDonVi_GVU";
            this.Text = "fDonVi_GVU";
            this.Load += new System.EventHandler(this.fDonVi_GVU_Load);
            this.gboxAction.ResumeLayout(false);
            this.gboxAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxAction;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxTrgDonVi;
        private System.Windows.Forms.DataGridView dgvDonVi;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
    }
}