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
    public partial class ChangePasswdForm : Form
    {
        public ChangePasswdForm()
        {
            InitializeComponent();
        }

        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        // 权限标记 值admin为管理员 ，值为user则为普通用户
        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // 定义数据库查询语句
            string sql;

            if (OldPasswdTextBox.Text.Trim() == "" || NewPasswdTextBox.Text.Trim() == "" || ReenterNewPasswdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整", "警告");
            }
            else if (NewPasswdTextBox.Text.Trim().Length < 6 || ReenterNewPasswdTextBox.Text.Trim().Length < 6)
            {
                MessageBox.Show("新密码长度必须大于六位", "提示");
            }
            else if (NewPasswdTextBox.Text.Trim() != ReenterNewPasswdTextBox.Text.Trim())
            {
                MessageBox.Show("两次输入的新密码不一致", "警告");
            }
            else
            {

                if (_Tag == "user")
                {
                    sql = "update users set userPasswd = @newPasswd where userId = @Id and userPasswd = @oldPasswd";
                }
                else
                {
                    sql = "update admin set adminPasswd = @newPasswd where adminId = @Id and adminPasswd = @oldPasswd";
                }

               
                MyDictionary dic = new MyDictionary();
                dic.Add("@newPasswd", NewPasswdTextBox.Text.Trim());
                dic.Add("@Id", ID.ToString());
                dic.Add("@oldPasswd", OldPasswdTextBox.Text.Trim());
                int n = MySqlHelper.ExecuteNonQuery(sql, dic);

                if (n > 0)
                {
                    MessageBox.Show("修改成功", "OK");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误", "警告");
                }


            }
        }
    }
}
