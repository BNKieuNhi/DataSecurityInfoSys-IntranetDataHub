namespace QLDuLieuNoiBo
{
    partial class fCheckPrivileges
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
            this.dataGridView_ListPrivileges = new System.Windows.Forms.DataGridView();
            this.revokePrivilegesRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCot = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListPrivileges)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(125, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(628, 31);
            this.txtInput.TabIndex = 23;
            // 
            // lblKeyword
            // 
            this.lblKeyword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(12, 50);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(97, 25);
            this.lblKeyword.TabIndex = 22;
            this.lblKeyword.Text = "User/Role :";
            // 
            // dataGridView_ListPrivileges
            // 
            this.dataGridView_ListPrivileges.AllowUserToAddRows = false;
            this.dataGridView_ListPrivileges.AllowUserToDeleteRows = false;
            this.dataGridView_ListPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListPrivileges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListPrivileges.Location = new System.Drawing.Point(0, 106);
            this.dataGridView_ListPrivileges.MultiSelect = false;
            this.dataGridView_ListPrivileges.Name = "dataGridView_ListPrivileges";
            this.dataGridView_ListPrivileges.ReadOnly = true;
            this.dataGridView_ListPrivileges.RowHeadersWidth = 51;
            this.dataGridView_ListPrivileges.RowTemplate.Height = 24;
            this.dataGridView_ListPrivileges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListPrivileges.Size = new System.Drawing.Size(982, 354);
            this.dataGridView_ListPrivileges.TabIndex = 21;
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
            this.grantRolesToolStripMenuItem.Click += new System.EventHandler(this.grantRolesToolStripMenuItem_Click);
            // 
            // grantToolStripMenuItem
            // 
            this.grantToolStripMenuItem.Name = "grantToolStripMenuItem";
            this.grantToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.grantToolStripMenuItem.Text = "Grant Privileges";
            this.grantToolStripMenuItem.Click += new System.EventHandler(this.grantToolStripMenuItem_Click_1);
            // 
            // checkPrivilegesToolStripMenuItem
            // 
            this.checkPrivilegesToolStripMenuItem.Name = "checkPrivilegesToolStripMenuItem";
            this.checkPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(146, 27);
            this.checkPrivilegesToolStripMenuItem.Text = "Check Privileges";
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
            this.menuStrip1.Size = new System.Drawing.Size(982, 31);
            this.menuStrip1.TabIndex = 19;
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
            // btnCot
            // 
            this.btnCot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCot.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCot.Location = new System.Drawing.Point(521, 482);
            this.btnCot.Name = "btnCot";
            this.btnCot.Size = new System.Drawing.Size(296, 33);
            this.btnCot.TabIndex = 35;
            this.btnCot.Text = "Kiểm tra quyền theo mức cột";
            this.btnCot.UseVisualStyleBackColor = false;
            this.btnCot.Click += new System.EventHandler(this.btnCot_Click);
            // 
            // btnBang
            // 
            this.btnBang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.Location = new System.Drawing.Point(156, 482);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(321, 33);
            this.btnBang.TabIndex = 30;
            this.btnBang.Text = "Kiểm tra quyền theo mức bảng";
            this.btnBang.UseVisualStyleBackColor = false;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // fCheckPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.btnCot);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.dataGridView_ListPrivileges);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fCheckPrivileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Privileges";
            this.Load += new System.EventHandler(this.fCheckPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListPrivileges)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.DataGridView dataGridView_ListPrivileges;
        private System.Windows.Forms.ToolStripMenuItem revokePrivilegesRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.ToolStripMenuItem colPrivilegesToolStripMenuItem;
    }
}