using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string _ID;// 账号
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _name;
        public string Name1 // 姓名
        {
            get { return _name; }
            set { _name = value; }
        }

        // 权限标记 值为admin为管理员 ，值为user则为普通用户
        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        // 标记账户是否被锁定  1为锁定 
        private string _b;
        public string B
        {
            get { return _b; }
            set { _b = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_Tag == "user")
            {
                toolStripStatusLabel4.Text = "权限级别：普通用户";
                toolStripStatusLabel1.Text = "   " + Name1;

                //用户权限设置
                AddUserToolStripMenuItem.Enabled = false;
                DeleteUserToolStripMenuItem.Enabled = false;
                AddBookToolStripMenuItem.Enabled = false;
                DeleteBookToolStripMenuItem.Enabled = false;

                if (B == "1")
                {
                    toolStripStatusLabel6.Text = "状态：已封禁";
                    MessageBox.Show("账户被锁定，请尽快联系管理员", "警告");
                }
            }
            else
            {
                toolStripStatusLabel4.Text = "权限级别：管理员";
                toolStripStatusLabel1.Text = "   " + Name1;
            }
        }

        // 退出时关闭所有窗口（login）
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region 修改密码
        private void ChangePasswd()
        {
            ChangePasswdForm cPF = new ChangePasswdForm();
            cPF.ID = ID;
            cPF._Tag = _Tag;
            cPF.ShowDialog();
        }

        private void ChangePasswdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswd();
        }
        #endregion
 
        #region 修改个人信息
        private void ModifyUserInfo()
        {
            ModifyUserInfoForm mui = new ModifyUserInfoForm();
            mui.P = "0";
            mui.Id = ID;
            mui._Tag = _Tag;
            mui.ShowDialog();
        }
        private void ModifyUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyUserInfo();
        }
        #endregion

        #region 添加用户
        private void AddUser()
        {
            ModifyUserInfoForm mui = new ModifyUserInfoForm();
            mui.Id = ID;
            mui._Tag = _Tag;
            mui.P = "1";
            mui.Text = "新用户注册";
            mui.ShowDialog();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        #endregion

        #region 注销用户
        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyUserInfoForm deleteForm = new ModifyUserInfoForm();
            deleteForm.Text = "注销用户";
            deleteForm.P = "2";
            deleteForm.ShowDialog();
        }
        #endregion

        #region 添加图书
        private void AddBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm aBF = new AddBookForm();
            aBF.ShowDialog();
        }
        #endregion

        #region 删除图书
        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBookForm dBF = new DeleteBookForm();
            dBF.ShowDialog();
        }
        #endregion

        #region 图书查询
        private void SearchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm sBF = new SearchBookForm();
            sBF._Tag = this._Tag;
            sBF.ShowDialog();
        }
        #endregion
    }
}
