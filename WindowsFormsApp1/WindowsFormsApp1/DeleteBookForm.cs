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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            if(DeleteBookIdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请填写需要注销的图书编号！", "警告");
            }
            else if(!MySqlHelper.IsBookExistsWithId(DeleteBookIdTextBox.Text.Trim()))
            {
                MessageBox.Show("无此图书，请输入正确的图书编号！", "警告");
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
                    string sql = "delete from books where bookId = @bookId";
                    MyDictionary dic = new MyDictionary();
                    dic.Add("@bookId", DeleteBookIdTextBox.Text.Trim());
                    int i = MySqlHelper.ExecuteNonQuery(sql, dic);
                    if (i == 1)
                    {
                        MessageBox.Show("注销成功");
                    }
                }
                this.Close();
            }
        }
    }
}
