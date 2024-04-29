namespace QLDuLieuNoiBo
{
    partial class fUsers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokePrivilegesRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView_ListUsers = new System.Windows.Forms.DataGridView();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblUID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.lblIDUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.radBtnLock = new System.Windows.Forms.RadioButton();
            this.radBtnUnlock = new System.Windows.Forms.RadioButton();
            this.radBtnCascade = new System.Windows.Forms.RadioButton();
<<<<<<< HEAD:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/Admin/fUsers.Designer.cs
            this.lblAction = new System.Windows.Forms.Label();
=======
>>>>>>> d2bd337147d6ab70f410a77f21fa8087d80b61e7:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/fUsers.Designer.cs
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(844, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuQuanLy";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.roleToolStripMenuItem.Text = "Roles";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // checkPrivilegesToolStripMenuItem
            // 
            this.checkPrivilegesToolStripMenuItem.Name = "checkPrivilegesToolStripMenuItem";
            this.checkPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(146, 27);
            this.checkPrivilegesToolStripMenuItem.Text = "Check Privileges";
            this.checkPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.checkPrivilegesToolStripMenuItem_Click);
            // 
            // grantToolStripMenuItem
            // 
            this.grantToolStripMenuItem.Name = "grantToolStripMenuItem";
            this.grantToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.grantToolStripMenuItem.Text = "Grant Privileges";
            this.grantToolStripMenuItem.Click += new System.EventHandler(this.grantToolStripMenuItem_Click);
            // 
            // grantRolesToolStripMenuItem
            // 
            this.grantRolesToolStripMenuItem.Name = "grantRolesToolStripMenuItem";
            this.grantRolesToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.grantRolesToolStripMenuItem.Text = "Grant Roles";
            this.grantRolesToolStripMenuItem.Click += new System.EventHandler(this.grantRolesToolStripMenuItem_Click);
            // 
            // revokePrivilegesRoleToolStripMenuItem
            // 
            this.revokePrivilegesRoleToolStripMenuItem.Name = "revokePrivilegesRoleToolStripMenuItem";
            this.revokePrivilegesRoleToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.revokePrivilegesRoleToolStripMenuItem.Text = "Revoke Roles";
            this.revokePrivilegesRoleToolStripMenuItem.Click += new System.EventHandler(this.revokePrivilegesRoleToolStripMenuItem_Click);
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
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(427, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView_ListUsers
            // 
            this.dataGridView_ListUsers.AllowUserToAddRows = false;
            this.dataGridView_ListUsers.AllowUserToDeleteRows = false;
            this.dataGridView_ListUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListUsers.Location = new System.Drawing.Point(0, 113);
            this.dataGridView_ListUsers.MultiSelect = false;
            this.dataGridView_ListUsers.Name = "dataGridView_ListUsers";
            this.dataGridView_ListUsers.ReadOnly = true;
            this.dataGridView_ListUsers.RowHeadersWidth = 51;
            this.dataGridView_ListUsers.RowTemplate.Height = 24;
            this.dataGridView_ListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListUsers.Size = new System.Drawing.Size(844, 260);
            this.dataGridView_ListUsers.TabIndex = 3;
            this.dataGridView_ListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListUsers_CellClick);
            // 
            // lblKeyword
            // 
            this.lblKeyword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(12, 45);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(80, 25);
            this.lblKeyword.TabIndex = 5;
            this.lblKeyword.Text = "Từ khóa:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(98, 42);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(313, 31);
            this.txtKeyword.TabIndex = 6;
            // 
            // txtUName
            // 
            this.txtUName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(120, 466);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(259, 31);
            this.txtUName.TabIndex = 8;
            // 
            // lblUID
            // 
            this.lblUID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.Location = new System.Drawing.Point(17, 466);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(95, 25);
            this.lblUID.TabIndex = 7;
            this.lblUID.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(501, 466);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 31);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(404, 469);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 25);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(141, 521);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(245, 521);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 33);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(349, 521);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUId
            // 
            this.txtUId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUId.Location = new System.Drawing.Point(120, 426);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(259, 31);
            this.txtUId.TabIndex = 16;
            // 
            // lblIDUser
            // 
            this.lblIDUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIDUser.AutoSize = true;
            this.lblIDUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUser.Location = new System.Drawing.Point(17, 426);
            this.lblIDUser.Name = "lblIDUser";
            this.lblIDUser.Size = new System.Drawing.Size(74, 25);
            this.lblIDUser.TabIndex = 15;
            this.lblIDUser.Text = "ID User:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(557, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 33);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRecord.BackColor = System.Drawing.Color.Moccasin;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(453, 521);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(98, 33);
            this.btnRecord.TabIndex = 18;
            this.btnRecord.Text = "Ghi";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // radBtnLock
            // 
            this.radBtnLock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radBtnLock.AutoSize = true;
            this.radBtnLock.Location = new System.Drawing.Point(501, 434);
            this.radBtnLock.Name = "radBtnLock";
            this.radBtnLock.Size = new System.Drawing.Size(57, 20);
            this.radBtnLock.TabIndex = 21;
            this.radBtnLock.TabStop = true;
            this.radBtnLock.Text = "Lock";
            this.radBtnLock.UseVisualStyleBackColor = true;
            // 
            // radBtnUnlock
            // 
            this.radBtnUnlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radBtnUnlock.AutoSize = true;
            this.radBtnUnlock.Location = new System.Drawing.Point(575, 434);
            this.radBtnUnlock.Name = "radBtnUnlock";
            this.radBtnUnlock.Size = new System.Drawing.Size(70, 20);
            this.radBtnUnlock.TabIndex = 22;
            this.radBtnUnlock.TabStop = true;
            this.radBtnUnlock.Text = "Unlock";
            this.radBtnUnlock.UseVisualStyleBackColor = true;
            // 
            // radBtnCascade
            // 
            this.radBtnCascade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radBtnCascade.AutoSize = true;
            this.radBtnCascade.Location = new System.Drawing.Point(665, 434);
            this.radBtnCascade.Name = "radBtnCascade";
            this.radBtnCascade.Size = new System.Drawing.Size(92, 20);
            this.radBtnCascade.TabIndex = 23;
            this.radBtnCascade.TabStop = true;
            this.radBtnCascade.Text = "CASCADE";
            this.radBtnCascade.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/Admin/fUsers.Designer.cs
            // lblAction
            // 
            this.lblAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Brown;
            this.lblAction.Location = new System.Drawing.Point(17, 391);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(70, 25);
            this.lblAction.TabIndex = 37;
            this.lblAction.Text = "Action:";
            this.lblAction.Visible = false;
            // 
=======
>>>>>>> d2bd337147d6ab70f410a77f21fa8087d80b61e7:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/fUsers.Designer.cs
            // fUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 584);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.radBtnCascade);
            this.Controls.Add(this.radBtnUnlock);
            this.Controls.Add(this.radBtnLock);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtUId);
            this.Controls.Add(this.lblIDUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.dataGridView_ListUsers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User List";
            this.Load += new System.EventHandler(this.fUsers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokePrivilegesRoleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView_ListUsers;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.Label lblIDUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.RadioButton radBtnLock;
        private System.Windows.Forms.RadioButton radBtnUnlock;
        private System.Windows.Forms.RadioButton radBtnCascade;
        private System.Windows.Forms.ToolStripMenuItem colPrivilegesToolStripMenuItem;
        private System.Windows.Forms.Label lblAction;
    }
}