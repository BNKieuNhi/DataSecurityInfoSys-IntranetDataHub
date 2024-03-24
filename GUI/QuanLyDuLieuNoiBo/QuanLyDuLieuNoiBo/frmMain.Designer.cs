namespace QuanLyDuLieuNoiBo
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokePrivilegesRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 393);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(71, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.checkPrivilegesToolStripMenuItem,
            this.grantPrivilegesToolStripMenuItem,
            this.grantRolesToolStripMenuItem,
            this.revokePrivilegesRoleToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(194, 393);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(181, 23);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(181, 23);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // checkPrivilegesToolStripMenuItem
            // 
            this.checkPrivilegesToolStripMenuItem.Name = "checkPrivilegesToolStripMenuItem";
            this.checkPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(181, 23);
            this.checkPrivilegesToolStripMenuItem.Text = "Check Privileges";
            // 
            // grantPrivilegesToolStripMenuItem
            // 
            this.grantPrivilegesToolStripMenuItem.Name = "grantPrivilegesToolStripMenuItem";
            this.grantPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(181, 23);
            this.grantPrivilegesToolStripMenuItem.Text = "Grant Privileges";
            // 
            // grantRolesToolStripMenuItem
            // 
            this.grantRolesToolStripMenuItem.Name = "grantRolesToolStripMenuItem";
            this.grantRolesToolStripMenuItem.Size = new System.Drawing.Size(181, 23);
            this.grantRolesToolStripMenuItem.Text = "Grant Roles";
            // 
            // revokePrivilegesRoleToolStripMenuItem
            // 
            this.revokePrivilegesRoleToolStripMenuItem.Name = "revokePrivilegesRoleToolStripMenuItem";
            this.revokePrivilegesRoleToolStripMenuItem.Size = new System.Drawing.Size(181, 23);
            this.revokePrivilegesRoleToolStripMenuItem.Text = "Revoke Privileges Role";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 54);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Quản lý dữ liệu nội bộ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokePrivilegesRoleToolStripMenuItem;
    }
}