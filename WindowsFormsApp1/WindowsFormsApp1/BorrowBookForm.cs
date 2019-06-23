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
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            BorrowBookUserTextBox.ReadOnly = false;
            BorrowBookUserTextBox.Text = Id;
            BorrowBookUserTextBox.ReadOnly = true;
            if (_Tag == "admin")
            {
                SubmitButton.Enabled = false;
            }
        }

        // 查询图书
        private void BorrowBookSearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBookNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("书名不能为空", "警告");
            }
            else
            {
                string sql = string.Format("select bookId, bookName, author, score, press, price, amount from books where bookName like '%" + SearchBookNameTextBox.Text.Trim() + "%'");
                DataTable dt = MySqlHelper.GetList(sql);
                this.BorrowBookDataGridView.DataSource = dt;
            }
        }

        private void BorrowBookDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = BorrowBookDataGridView.CurrentRow.Index;
            BorrowBookIdTextBox.ReadOnly = false;
            BorrowBookNameTextBox.ReadOnly = false;
            BorrowBookPriceTextBox.ReadOnly = false;
            BorrowBookIdTextBox.Text = BorrowBookDataGridView.Rows[a].Cells["ColumnBookId"].Value.ToString();
            BorrowBookNameTextBox.Text = BorrowBookDataGridView.Rows[a].Cells["ColumnBookName"].Value.ToString();
            BorrowBookPriceTextBox.Text = BorrowBookDataGridView.Rows[a].Cells["ColumnPrice"].Value.ToString();
            BorrowBookIdTextBox.ReadOnly = true;
            BorrowBookNameTextBox.ReadOnly = true;
            BorrowBookPriceTextBox.ReadOnly = true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (BorrowBookTimeComboBox.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请选择借阅时长！", "警告");
                return;
            }
            else if (BorrowBookIdTextBox.Text.Trim() == "" || BorrowBookNameTextBox.Text.Trim() == "" || BorrowBookPriceTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请选择书籍！", "警告");
            }
            else
            {
                // 自动生成借书单号
                string sql = "select COUNT(*)+1 from borrowlist";
                string borrowNumber = MySqlHelper.ExecuteScalar(sql).ToString();
                StringBuilder sb = new StringBuilder(borrowNumber);
                while (sb.Length != 6)
                {
                    sb.Insert(0, "0");
                }
                borrowNumber = sb.ToString();

                // 查询书籍库存量
                sql = "select amount from books where bookId = @bookId";
                MyDictionary dic1 = new MyDictionary();
                dic1.Add("@bookId", BorrowBookIdTextBox.Text.Trim());
                string n = MySqlHelper.ExecuteScalar(sql, dic1).ToString();
                if (n == "0")
                {
                    MessageBox.Show("该书籍库存量为零！", "警告");
                    return;
                }

                // 插入数据到借书表（borrow）
                //sql = string.Format("insert into borrowlist values(@borrowNumber, @userId, @bookId, @bookName, convert(varchar(20),GETDATE() ,111),convert(varchar(20),dateadd(day," + BorrowBookTimeComboBox.Text.ToString().Substring(0, 2) + ", CONVERT(varchar(20),GETDATE() ,111)),111), @overDue)");
                //sql = string.Format("insert into borrowlist values(@borrowNumber, @userId, @bookId, @bookName, curdate(), date_add(curdate(), interval 30 day), @overDue)");
                sql = string.Format("insert into borrowlist values(@borrowNumber, @userId, @bookId, @bookName, curdate(), date_add(curdate(), interval @duration day), @overDue)");
                MyDictionary dic = new MyDictionary();
                dic.Add("@borrowNumber", borrowNumber);
                dic.Add("@userId", BorrowBookUserTextBox.Text.Trim());
                dic.Add("@bookId", BorrowBookIdTextBox.Text.Trim());
                dic.Add("@bookName", BorrowBookNameTextBox.Text.Trim());
                dic.Add("@duration", BorrowBookTimeComboBox.Text.ToString().Substring(0, 2));       //借书时长
                dic.Add("@overDue", "0");   // overDue = 0 标记该书未超归还期限 
                int i = MySqlHelper.ExecuteNonQuery(sql, dic);
                if (i > 0)
                {
                    n = (Convert.ToInt32(n) - 1).ToString(); // 库存量 -1
                    sql = "update books set amount = @amount where bookId = @bookId";
                    MyDictionary dic2 = new MyDictionary();
                    dic2.Add("@amount", n);
                    dic2.Add("@bookId", BorrowBookIdTextBox.Text.Trim());
                    MySqlHelper.ExecuteScalar(sql, dic2);
                    MessageBox.Show("借书成功!", "提示");
                }
            }
        }
    }
}
