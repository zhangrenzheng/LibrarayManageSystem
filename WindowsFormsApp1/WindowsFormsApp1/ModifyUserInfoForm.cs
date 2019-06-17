using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModifyUserInfoForm : Form
    {
        public ModifyUserInfoForm()
        {
            InitializeComponent();
        }

        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        // 权限标记值 admin 为管理员 ，user则为普通用户
        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        // P标记用来决定是否隐藏panel
        private string _p;
        public string P
        {
            get { return _p; }
            set { _p = value; }
        }

        #region 窗体配置
        private void ModifyUserInfoForm_Load(object sender, EventArgs e)
        {
            if (P == "1")       // p == "1"  为注册新用户功能
            {
                DeleteUserPanel.Visible = false;
            }
            else if (P == "2")  // p == "2"  为注销用户功能
            {
            }
            else                //          为修改个人信息
            {
                AddUserPanel.Visible = false;
                DeleteUserPanel.Visible = false;
                string connectString = "server=localhost;User Id=root;password=123456;Database=library;";
                string sql;
                if (_Tag == "user")
                {
                    sql = "select * from users where userId='" + Id + "'";
                }
                else
                {
                    sql = "select * from admin where adminId='" + Id + "'";
                }
                using (MySqlConnection conn = new MySqlConnection(connectString))
                {
                    MySqlCommand myCommand = new MySqlCommand(sql, conn);
                    conn.Open();
                    // ExecuteReader()返回一个Datareader对象，这个对象的内容就是与命令匹配的所有行
                    using (MySqlDataReader reader = myCommand.ExecuteReader())
                    {
                        reader.Read();
                        //MessageBox.Show(reader.GetString(3), "调试");
                        AccountTextBox.Text = reader.GetString(1);
                        NameTextBox.Text = reader.GetString(0);
                        PhoneNumberTextBox.Text = reader.GetString(4);
                        if (_Tag == "user")
                        {
                            if (reader.GetString(5) == "1")
                            {
                                StatusDisplayLabel.Text = "封禁";
                            }
                            else
                            {
                                StatusDisplayLabel.Text = "正常";
                            }
                        }
                        else
                        {
                            StatusDisplayLabel.Text = "正常";
                        }

                        if (reader.GetString(3) == "男")
                        {
                            MaleRadioButton.Checked = true;
                        }
                        else
                        {
                            FemaleRadioButton.Checked = true;
                        }
                    }
                    myCommand.Dispose();
                }
                SubmitButton.Enabled = false;
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
        private void AccountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AccountTextBox.Text != Id)
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }
        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
        #endregion

        #region 修改用户信息
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // 判断账号是否存在
            if (AccountTextBox.Text != Id)
            {
                if (MySqlHelper.IsUserExists(AccountTextBox.Text.Trim()))
                {
                    MessageBox.Show("账号已存在!", "提示");
                    return;
                }
            }

            // 完成用户的修改
            string userName = NameTextBox.Text.Trim();
            string userId = AccountTextBox.Text.Trim();
            string userPhoneNumber = PhoneNumberTextBox.Text.Trim();
            string userSex;
            if (MaleRadioButton.Checked == true)
            {
                userSex = "男";
            }
            else
            {
                userSex = "女";
            }

            // 构造sql语句
            string sql;
            if (_Tag == "user")
            {
                sql = "update users set userId = @userId, userName = @userName, userSex = @userSex, userPhoneNumber = @userPhoneNumber where userId = @Id";
            }
            else
            {
                sql = "update admin set adminId = @userId, adminName = @userName, adminSex = @userSex, adminPhoneNumber = @userPhoneNumber where adminId = @Id";
            }

            MyDictionary dic = new MyDictionary();
            dic.Add("@userId", userId);
            dic.Add("@userName", userName);
            dic.Add("@userSex", userSex);
            dic.Add("@userPhoneNumber", userPhoneNumber);
            dic.Add("@Id", Id);
            // 执行并返回
            int i = MySqlHelper.ExecuteNonQuery(sql, dic);

            if (i == 1)
            {
                MessageBox.Show("修改用户信息成功！", "提示");
            }
            this.Close();
        }
        #endregion

        #region 注销用户
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            // 判断账号是否存在
            if (!MySqlHelper.IsUserExists(DeleteUserAccountTextBox.Text.Trim()))
            {
                MessageBox.Show("账号不存在！", "提示");
                return;
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要注销此用户吗？", "提示", MessageBoxButtons.OKCancel);
                if (dt != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    string sql = "delete from users where userId=@id";
                    MyDictionary dic = new MyDictionary();
                    dic.Add("@id", DeleteUserAccountTextBox.Text.Trim());
                    int i = MySqlHelper.ExecuteNonQuery(sql, dic);
                    if (i == 1)
                    {
                        MessageBox.Show("注销成功");
                    }
                }
                this.Close();
            }
        }
        #endregion

        #region 注册用户
        private void AddUserSubmitButton_Click(object sender, EventArgs e)
        {
            string userSex = "";
            if (AddUserAccountTextbox.Text.Trim().Length < 5)
            {
                MessageBox.Show("账号长度应该大于5!", "提示");
            }
            else if (AddUserPasswdTextBox.Text.Trim().Length < 5)
            {
                MessageBox.Show("密码长度应该大于5!", "提示");
            }
            else if (AddUserNameLabelTextBox.Text.Trim().Length < 2 || AddUserNameLabelTextBox.Text.Trim().Length > 15)
            {
                MessageBox.Show("姓名长度应该大于1并且小于等于15!", "提示");
            }
            else if (AddUserMaleRadioButton.Checked == false && AddUserFemaleRadioButton.Checked == false)
            {
                MessageBox.Show("请选择性别!", "提示");
            }

            else if (Regex.IsMatch(AddUserPhoneNumberTextBox.Text.Trim(), @"^1\d{10}$") != true && Regex.IsMatch(AddUserPhoneNumberTextBox.Text.Trim(), @"^(\d{3,4}-)?\d{6,8}$") != true)
            {
                MessageBox.Show("请输入合法的手机号码或电话号码!", "提示");
            }

            else
            {
                // 判断判断账号是否存在
                if (MySqlHelper.IsUserExists(AddUserAccountTextbox.Text.Trim()))
                {
                    MessageBox.Show("账号已存在!", "警告");
                    return;
                }

                if (AddUserMaleRadioButton.Checked == true)
                {
                    userSex = "男";
                }
                else
                {
                    userSex = "女";
                }

                // 添加新用户
                string sql = "insert into users (userName,userId,userPasswd,userSex,userPhoneNumber,userBan) values(@userName,@userId,@userPasswd,@userSex,@userPhoneNumber,'0')";
                MyDictionary dic = new MyDictionary();
                dic.Add("@userId", AddUserAccountTextbox.Text.Trim());
                dic.Add("@userPasswd", AddUserPasswdTextBox.Text.Trim());
                dic.Add("@userName", AddUserNameLabelTextBox.Text.Trim());
                dic.Add("@userSex", userSex);
                dic.Add("@userPhoneNumber", AddUserPhoneNumberTextBox.Text.Trim());
                int i = MySqlHelper.ExecuteNonQuery(sql, dic);
                if (i == 1)
                {
                    MessageBox.Show("注册用户成功!", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败,请联系管理员!", "警告");
                }
            }
        }
        #endregion
    }
}
