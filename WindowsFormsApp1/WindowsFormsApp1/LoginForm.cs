using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBoxId.Text.Trim();
            string passwd = textBoxPwd.Text.Trim();

            if (ID == "" || passwd == "")
            {
                MessageBox.Show("请输入账号或密码!");
            }
            else
            {
                //数据库连接字符串
                String connectString = "server=localhost;User Id=root;password=123456;Database=library;";
                //数据库语句
                String sql;

                if (radioButton1.Checked == true)
                {
                    sql = "select userName from users where userId = '" + ID + "' and userPasswd = '" + passwd + "'";
                }
                else
                {
                    sql = "select adminName from admin where adminId = '" + ID + "' and adminPasswd = '" + passwd + "'";
                }

                // 构造连接对象
                using (MySqlConnection conn = new MySqlConnection(connectString))
                {
                    MySqlCommand myCommand = new MySqlCommand(sql, conn);
                    // 打开数据库连接
                    conn.Open();
                    String name;
                    try
                    {
                        name = myCommand.ExecuteScalar().ToString();
                        //MessageBox.Show(name, "Name");

                        // 登录窗体隐藏
                        this.Hide();
                        // 创建主窗体
                        MainForm mainForm = new MainForm();

                        // 将账号传给主窗体MainForm
                        mainForm.ID = ID;
                        // 用主窗体MainForm下的_Tag标记登陆的是用户还是管理员
                        if (radioButton1.Checked == true)
                        {
                            mainForm._Tag = "user";
                            mainForm.Name1 = name;

                            sql = "select userBan from users where userId = '" + ID + "' and userPasswd = '" + passwd + "'";
                            myCommand = new MySqlCommand(sql, conn);
                            string b = myCommand.ExecuteScalar().ToString();
                            mainForm.B = b;
                        }
                        else
                        {
                            mainForm._Tag = "admin";
                            mainForm.Name1 = name;
                        }
                        conn.Close();
                        //显示主窗体
                        mainForm.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("账号或密码错误！", "登录失败");
                    }
                    finally
                    {

                    }
                }
            }

        }
    }
}
