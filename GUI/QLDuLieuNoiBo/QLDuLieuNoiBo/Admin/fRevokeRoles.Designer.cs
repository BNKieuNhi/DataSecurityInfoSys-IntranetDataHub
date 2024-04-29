namespace QLDuLieuNoiBo
{
    partial class fRevokeRoles
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revokePrivilegesRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKRevoke = new System.Windows.Forms.Label();
            this.dataGridView_ListUsers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbRoleUser = new System.Windows.Forms.ComboBox();
            this.lblRoleUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassword.Location = new System.Drawing.Point(219, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 25);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "ROLE";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(670, 85);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 33);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // revokePrivilegesRoleToolStripMenuItem
            // 
            this.revokePrivilegesRoleToolStripMenuItem.Name = "revokePrivilegesRoleToolStripMenuItem";
            this.revokePrivilegesRoleToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.revokePrivilegesRoleToolStripMenuItem.Text = "Revoke Roles";
            // 
            // grantRolesToolStripMenuItem
            // 
            this.grantRolesToolStripMenuItem.Name = "grantRolesToolStripMenuItem";
            this.grantRolesToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.grantRolesToolStripMenuItem.Text = "Grant Roles";
            this.grantRolesToolStripMenuItem.Click += new System.EventHandler(this.grantRolesToolStripMenuItem_Click);
            // 
            // grantToolStripMenuItem
            // 
            this.grantToolStripMenuItem.Name = "grantToolStripMenuItem";
            this.grantToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.grantToolStripMenuItem.Text = "Grant Privileges";
            this.grantToolStripMenuItem.Click += new System.EventHandler(this.grantToolStripMenuItem_Click);
            // 
            // checkPrivilegesToolStripMenuItem
            // 
            this.checkPrivilegesToolStripMenuItem.Name = "checkPrivilegesToolStripMenuItem";
            this.checkPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(146, 27);
            this.checkPrivilegesToolStripMenuItem.Text = "Check Privileges";
            this.checkPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.checkPrivilegesToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.roleToolStripMenuItem.Text = "Roles";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // lblKRevoke
            // 
            this.lblKRevoke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKRevoke.AutoSize = true;
            this.lblKRevoke.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKRevoke.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKRevoke.Location = new System.Drawing.Point(49, 90);
            this.lblKRevoke.Name = "lblKRevoke";
            this.lblKRevoke.Size = new System.Drawing.Size(76, 25);
            this.lblKRevoke.TabIndex = 22;
            this.lblKRevoke.Text = "REVOKE";
            // 
            // dataGridView_ListUsers
            // 
            this.dataGridView_ListUsers.AllowUserToAddRows = false;
            this.dataGridView_ListUsers.AllowUserToDeleteRows = false;
            this.dataGridView_ListUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListUsers.EnableHeadersVisualStyles = false;
            this.dataGridView_ListUsers.Location = new System.Drawing.Point(2, 149);
            this.dataGridView_ListUsers.MultiSelect = false;
            this.dataGridView_ListUsers.Name = "dataGridView_ListUsers";
            this.dataGridView_ListUsers.ReadOnly = true;
            this.dataGridView_ListUsers.RowHeadersWidth = 51;
            this.dataGridView_ListUsers.RowTemplate.Height = 24;
            this.dataGridView_ListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListUsers.Size = new System.Drawing.Size(897, 305);
            this.dataGridView_ListUsers.TabIndex = 21;
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
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuQuanLy";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 27);
            this.toolStripMenuItem1.Text = "Col Privileges";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // cbRole
            // 
            this.cbRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(144, 87);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(206, 31);
            this.cbRole.TabIndex = 27;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // cbRoleUser
            // 
            this.cbRoleUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRoleUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRoleUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRoleUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoleUser.FormattingEnabled = true;
            this.cbRoleUser.Location = new System.Drawing.Point(447, 87);
            this.cbRoleUser.Name = "cbRoleUser";
            this.cbRoleUser.Size = new System.Drawing.Size(204, 31);
            this.cbRoleUser.TabIndex = 30;
            // 
            // lblRoleUser
            // 
            this.lblRoleUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRoleUser.AutoSize = true;
            this.lblRoleUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRoleUser.Location = new System.Drawing.Point(498, 50);
            this.lblRoleUser.Name = "lblRoleUser";
            this.lblRoleUser.Size = new System.Drawing.Size(105, 25);
            this.lblRoleUser.TabIndex = 29;
            this.lblRoleUser.Text = "ROLE/USER";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(369, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "FROM";
            // 
            // fRevokeRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 456);
            this.Controls.Add(this.cbRoleUser);
            this.Controls.Add(this.lblRoleUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblKRevoke);
            this.Controls.Add(this.dataGridView_ListUsers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fRevokeRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revoke Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem revokePrivilegesRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Label lblKRevoke;
        private System.Windows.Forms.DataGridView dataGridView_ListUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbRoleUser;
        private System.Windows.Forms.Label lblRoleUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}