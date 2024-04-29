namespace QLDuLieuNoiBo
{
    partial class fGrantPrivileges
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.dataGridView_ListGrant = new System.Windows.Forms.DataGridView();
            this.revokePrivilegesRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListGrant)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(165, 45);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(628, 31);
            this.txtInput.TabIndex = 39;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(47, 49);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(97, 25);
            this.lblKeyword.TabIndex = 38;
            this.lblKeyword.Text = "User/Role :";
            // 
            // dataGridView_ListGrant
            // 
            this.dataGridView_ListGrant.AllowUserToAddRows = false;
            this.dataGridView_ListGrant.AllowUserToDeleteRows = false;
            this.dataGridView_ListGrant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListGrant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListGrant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListGrant.Location = new System.Drawing.Point(0, 103);
            this.dataGridView_ListGrant.Name = "dataGridView_ListGrant";
            this.dataGridView_ListGrant.RowHeadersWidth = 51;
            this.dataGridView_ListGrant.RowTemplate.Height = 24;
            this.dataGridView_ListGrant.Size = new System.Drawing.Size(967, 350);
            this.dataGridView_ListGrant.TabIndex = 37;
            // 
            // revokePrivilegesRoleToolStripMenuItem
            // 
            this.revokePrivilegesRoleToolStripMenuItem.Name = "revokePrivilegesRoleToolStripMenuItem";
            this.revokePrivilegesRoleToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.revokePrivilegesRoleToolStripMenuItem.Text = "Revoke Roles";
            this.revokePrivilegesRoleToolStripMenuItem.Click += new System.EventHandler(this.revokePrivilegesRoleToolStripMenuItem_Click);
            // 
            // grantRolesToolStripMenuItem
            // 
            this.grantRolesToolStripMenuItem.Name = "grantRolesToolStripMenuItem";
            this.grantRolesToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.grantRolesToolStripMenuItem.Text = "Grant Roles";
            this.grantRolesToolStripMenuItem.Click += new System.EventHandler(this.grantRolesToolStripMenuItem_Click_1);
            // 
            // grantToolStripMenuItem
            // 
            this.grantToolStripMenuItem.Name = "grantToolStripMenuItem";
            this.grantToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.grantToolStripMenuItem.Text = "Grant Privileges";
            // 
            // checkPrivilegesToolStripMenuItem
            // 
            this.checkPrivilegesToolStripMenuItem.Name = "checkPrivilegesToolStripMenuItem";
            this.checkPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(146, 27);
            this.checkPrivilegesToolStripMenuItem.Text = "Check Privileges";
            this.checkPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.checkPrivilegesToolStripMenuItem_Click_1);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.roleToolStripMenuItem.Text = "Roles";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click_1);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.checkPrivilegesToolStripMenuItem,
            this.grantToolStripMenuItem,
            this.grantRolesToolStripMenuItem,
            this.revokePrivilegesRoleToolStripMenuItem,
            this.colPrivilegesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 31);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuQuanLy";
            // 
            // colPrivilegesToolStripMenuItem
            // 
            this.colPrivilegesToolStripMenuItem.Name = "colPrivilegesToolStripMenuItem";
            this.colPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(125, 27);
            this.colPrivilegesToolStripMenuItem.Text = "Col Privileges";
            this.colPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.colPrivilegesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(319, 471);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(296, 32);
            this.btnConfirm.TabIndex = 41;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(822, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 33);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fGrantPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 525);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.dataGridView_ListGrant);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "fGrantPrivileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant Privileges";
            this.Load += new System.EventHandler(this.fGrantPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListGrant)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.DataGridView dataGridView_ListGrant;
        private System.Windows.Forms.ToolStripMenuItem revokePrivilegesRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem colPrivilegesToolStripMenuItem;
    }
}