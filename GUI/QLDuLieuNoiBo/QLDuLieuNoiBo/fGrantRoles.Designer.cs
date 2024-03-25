namespace QLDuLieuNoiBo
{
    partial class fGrantRoles
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
            this.lblKeyword = new System.Windows.Forms.Label();
            this.dataGridView_ListUsers = new System.Windows.Forms.DataGridView();
            this.revokePrivilegesRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fGrantRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbBox_Role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKeyword.Location = new System.Drawing.Point(26, 84);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(69, 25);
            this.lblKeyword.TabIndex = 38;
            this.lblKeyword.Text = "GRANT";
            // 
            // dataGridView_ListUsers
            // 
            this.dataGridView_ListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListUsers.Location = new System.Drawing.Point(0, 145);
            this.dataGridView_ListUsers.Name = "dataGridView_ListUsers";
            this.dataGridView_ListUsers.RowHeadersWidth = 51;
            this.dataGridView_ListUsers.RowTemplate.Height = 24;
            this.dataGridView_ListUsers.Size = new System.Drawing.Size(870, 273);
            this.dataGridView_ListUsers.TabIndex = 37;
            // 
            // revokePrivilegesRoleToolStripMenuItem
            // 
            this.revokePrivilegesRoleToolStripMenuItem.Name = "revokePrivilegesRoleToolStripMenuItem";
            this.revokePrivilegesRoleToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.revokePrivilegesRoleToolStripMenuItem.Text = "Revoke Roles";
            this.revokePrivilegesRoleToolStripMenuItem.Click += new System.EventHandler(this.revokePrivilegesRoleToolStripMenuItem_Click);
            // 
            // fGrantRolesToolStripMenuItem
            // 
            this.fGrantRolesToolStripMenuItem.Name = "fGrantRolesToolStripMenuItem";
            this.fGrantRolesToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.fGrantRolesToolStripMenuItem.Text = "Grant Roles";
            this.fGrantRolesToolStripMenuItem.Click += new System.EventHandler(this.fGrantRolesToolStripMenuItem_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.checkPrivilegesToolStripMenuItem,
            this.grantToolStripMenuItem,
            this.fGrantRolesToolStripMenuItem,
            this.revokePrivilegesRoleToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 31);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuQuanLy";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(578, 80);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 33);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbBox_Role
            // 
            this.cbBox_Role.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBox_Role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBox_Role.FormattingEnabled = true;
            this.cbBox_Role.Location = new System.Drawing.Point(116, 84);
            this.cbBox_Role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBox_Role.Name = "cbBox_Role";
            this.cbBox_Role.Size = new System.Drawing.Size(186, 24);
            this.cbBox_Role.TabIndex = 42;
            this.cbBox_Role.SelectedIndexChanged += new System.EventHandler(this.cbBox_Role_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(328, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(179, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "ROLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(442, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "USER";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(383, 78);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(176, 30);
            this.txtInput.TabIndex = 46;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 27);
            this.toolStripMenuItem1.Text = "Col Privileges";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fGrantRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 418);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBox_Role);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dataGridView_ListUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fGrantRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant Roles";
            this.Load += new System.EventHandler(this.fGrantRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.DataGridView dataGridView_ListUsers;
        private System.Windows.Forms.ToolStripMenuItem revokePrivilegesRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fGrantRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbBox_Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}