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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }
        private void AddBookSubmitButton_Click(object sender, EventArgs e)
        {
            if (AddBookIdTextBox.Text.Trim() == "" || AddBookNameTextBox.Text.Trim() == "" || AddBookAuthorTextBox.Text.Trim() == "" || AddBookScoreTextBox.Text.Trim() == "" || AddBookPressTextBox.Text.Trim() == "" || AddBookPriceTextBox.Text.Trim() == "" || AddBookAmountTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息！", "警告");
            }
            else if (MySqlHelper.IsBookExistsWithId(AddBookIdTextBox.Text.Trim()))
            {
                MessageBox.Show("图书编号已存在!", "警告");
                return;
            }
            else
            { 
                // 添加操作
                string sql = "insert into books values(@bookId, @bookName, @author, @score, @press, @price, @amount)";
                MyDictionary dic = new MyDictionary();
                dic.Add("@bookId", AddBookIdTextBox.Text.Trim());
                dic.Add("@bookName", AddBookNameTextBox.Text.Trim());
                dic.Add("@author", AddBookAuthorTextBox.Text.Trim());
                dic.Add("@score", AddBookScoreTextBox.Text.Trim());
                dic.Add("@press", AddBookPressTextBox.Text.Trim());
                dic.Add("@price", AddBookPriceTextBox.Text.Trim());
                dic.Add("@amount", AddBookAmountTextBox.Text.Trim());
                int i = MySqlHelper.ExecuteNonQuery(sql, dic);
                if (i == 1)
                {
                    MessageBox.Show("图书添加成功!", "提示");
                }
            }
        }
    }
}
