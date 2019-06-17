namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStripMenuItem,
            this.用户信息修改ToolStripMenuItem,
            this.DeleteUserToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddUserToolStripMenuItem.Text = "注册用户";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // 用户信息修改ToolStripMenuItem
            // 
            this.用户信息修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyUserInfoToolStripMenuItem,
            this.ChangePasswdToolStripMenuItem});
            this.用户信息修改ToolStripMenuItem.Name = "用户信息修改ToolStripMenuItem";
            this.用户信息修改ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.用户信息修改ToolStripMenuItem.Text = "用户信息修改";
            // 
            // ModifyUserInfoToolStripMenuItem
            // 
            this.ModifyUserInfoToolStripMenuItem.Name = "ModifyUserInfoToolStripMenuItem";
            this.ModifyUserInfoToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.ModifyUserInfoToolStripMenuItem.Text = "修改信息";
            this.ModifyUserInfoToolStripMenuItem.Click += new System.EventHandler(this.ModifyUserInfoToolStripMenuItem_Click);
            // 
            // ChangePasswdToolStripMenuItem
            // 
            this.ChangePasswdToolStripMenuItem.Name = "ChangePasswdToolStripMenuItem";
            this.ChangePasswdToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.ChangePasswdToolStripMenuItem.Text = "修改密码";
            this.ChangePasswdToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswdToolStripMenuItem_Click);
            // 
            // DeleteUserToolStripMenuItem
            // 
            this.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem";
            this.DeleteUserToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.DeleteUserToolStripMenuItem.Text = "注销用户";
            this.DeleteUserToolStripMenuItem.Click += new System.EventHandler(this.DeleteUserToolStripMenuItem_Click);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBookToolStripMenuItem,
            this.借书管理ToolStripMenuItem,
            this.还书管理ToolStripMenuItem,
            this.DeleteBookToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // AddBookToolStripMenuItem
            // 
            this.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem";
            this.AddBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddBookToolStripMenuItem.Text = "图书入库";
            this.AddBookToolStripMenuItem.Click += new System.EventHandler(this.AddBookToolStripMenuItem_Click);
            // 
            // 借书管理ToolStripMenuItem
            // 
            this.借书管理ToolStripMenuItem.Name = "借书管理ToolStripMenuItem";
            this.借书管理ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.借书管理ToolStripMenuItem.Text = "借书管理";
            // 
            // 还书管理ToolStripMenuItem
            // 
            this.还书管理ToolStripMenuItem.Name = "还书管理ToolStripMenuItem";
            this.还书管理ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.还书管理ToolStripMenuItem.Text = "还书管理";
            // 
            // DeleteBookToolStripMenuItem
            // 
            this.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem";
            this.DeleteBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.DeleteBookToolStripMenuItem.Text = "删除图书";
            this.DeleteBookToolStripMenuItem.Click += new System.EventHandler(this.DeleteBookToolStripMenuItem_Click);
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchBookToolStripMenuItem,
            this.借书单查询ToolStripMenuItem,
            this.用户查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            // 
            // SearchBookToolStripMenuItem
            // 
            this.SearchBookToolStripMenuItem.Name = "SearchBookToolStripMenuItem";
            this.SearchBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.SearchBookToolStripMenuItem.Text = "图书查询";
            this.SearchBookToolStripMenuItem.Click += new System.EventHandler(this.SearchBookToolStripMenuItem_Click);
            // 
            // 借书单查询ToolStripMenuItem
            // 
            this.借书单查询ToolStripMenuItem.Name = "借书单查询ToolStripMenuItem";
            this.借书单查询ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.借书单查询ToolStripMenuItem.Text = "借书单查询";
            // 
            // 用户查询ToolStripMenuItem
            // 
            this.用户查询ToolStripMenuItem.Name = "用户查询ToolStripMenuItem";
            this.用户查询ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.用户查询ToolStripMenuItem.Text = "用户查询";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel1.Text = "   ***";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(190, 21);
            this.toolStripStatusLabel2.Text = "，欢迎登陆图书管理系统！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(120, 21);
            this.toolStripStatusLabel3.Text = "                      ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(145, 21);
            this.toolStripStatusLabel4.Text = "权限级别：普通用户";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(110, 21);
            this.toolStripStatusLabel5.Text = "                    ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(85, 21);
            this.toolStripStatusLabel6.Text = "状态：正常";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户查询ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
    }
}