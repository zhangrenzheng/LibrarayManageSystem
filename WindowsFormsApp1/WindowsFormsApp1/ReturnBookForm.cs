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
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
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

        // 标记账户是否被锁定  1为锁定 
        private string _b;
        public string B
        {
            get { return _b; }
            set { _b = value; }
        }

        private void ShowBorrowList()
        {
            string sql;
            if (_Tag == "user")
            {
                sql = string.Format("select borrowNumber, userId, bookId, bookName, borrowingDate, returnDate, overDue from borrowlist where userId = '" + Id + "'");
            }
            else
            {
                sql = string.Format("select borrowNumber, userId, bookId, bookName, borrowingDate, returnDate, overDue from borrowlist where userId = '" + ReturnBookIdTextBox.Text.Trim() + "'");
            }
            DataTable dt = MySqlHelper.GetList(sql);
            this.ReturnBookDataGridView.DataSource = dt;
        }
        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            if (_Tag == "user")
            {
                ReturnBookSearchButton.Visible = false;
                ReturnBookIdTextBox.ReadOnly = false;
                ReturnBookIdTextBox.Text = Id;
                ReturnBookIdTextBox.ReadOnly = true;
                ShowBorrowList();

                // 被封禁用户禁止提交还书
                if (B == "1")
                {
                    ReturnBookSubmitButton.Enabled = false;
                }
            }
        }

        private void ReturnBookSearchButton_Click(object sender, EventArgs e)
        {
            if(ReturnBookIdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请填写需要查询的账号！", "警告");
            }
            ShowBorrowList();
        }

        private void ReturnBookDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = ReturnBookDataGridView.CurrentRow.Index;
            BorrowNumberTextBox.ReadOnly = false;
            ReturnBookUserIdTextBox.ReadOnly = false;
            OverDueTextBox.ReadOnly = false;
            BookIdTextBox.ReadOnly = false;
            BookNameTextBox.ReadOnly = false;
            BorrowingDateTextBox.ReadOnly = false;
            ReturnDateTextBox.ReadOnly = false;

            BorrowNumberTextBox.Text = ReturnBookDataGridView.Rows[a].Cells["ColumnBorrowNumber"].Value.ToString();
            ReturnBookUserIdTextBox.Text = ReturnBookDataGridView.Rows[a].Cells["ColumnUserId"].Value.ToString();
            OverDueTextBox.Text = (ReturnBookDataGridView.Rows[a].Cells["ColumnOverDue"].Value.ToString() == "1") ? "是" : "否";
            BookIdTextBox.Text = ReturnBookDataGridView.Rows[a].Cells["ColumnBookId"].Value.ToString();
            BookNameTextBox.Text = ReturnBookDataGridView.Rows[a].Cells["ColumnBookName"].Value.ToString();
            BorrowingDateTextBox.Text = ReturnBookDataGridView.Rows[a].Cells["ColumnBorrowingDate"].Value.ToString();
            ReturnDateTextBox.Text = ReturnBookDataGridView.Rows[a].Cells["ColumnReturnDate"].Value.ToString();
          
            BorrowNumberTextBox.ReadOnly = true;
            ReturnBookUserIdTextBox.ReadOnly = true;
            OverDueTextBox.ReadOnly = true;
            BookIdTextBox.ReadOnly = true;
            BookNameTextBox.ReadOnly = true;
            BorrowingDateTextBox.ReadOnly = true;
            ReturnDateTextBox.ReadOnly = true;
        }

        private void ReturnBookSubmitButton_Click(object sender, EventArgs e)
        {
            string sql = "select userBan from users where userId = @userID";
            MyDictionary dic3 = new MyDictionary();
            dic3.Add("@userID", ReturnBookUserIdTextBox.Text.Trim());
            if (MySqlHelper.ExecuteScalar(sql, dic3).ToString() == "1")
            {
                MessageBox.Show("因逾期未还书账户被锁定，请及时解锁，并缴纳罚款！", "警告");
                return;
            }
            else
            {
                // 办理借书手续
                // 删除借书记录 
                sql = "delete from borrowlist where borrowNumber = @borrowNumber";
                MyDictionary dic4 = new MyDictionary();
                dic4.Add("@borrowNumber", BorrowNumberTextBox.Text.Trim());
                MySqlHelper.ExecuteNonQuery(sql, dic4);

                // 得到书籍库存量 并+1
                sql = "select amount from books where bookId = @bookId";
                MyDictionary dic5 = new MyDictionary();
                dic5.Add("@bookId", BookIdTextBox.Text.Trim());
                int n = Convert.ToInt32(MySqlHelper.ExecuteScalar(sql, dic5)) + 1;

                sql = "update books set amount = @amount where bookId = @bookId";
                MyDictionary dic6 = new MyDictionary();
                dic6.Add("@amount", n.ToString());
                dic6.Add("@bookId", BookIdTextBox.Text.Trim());
                MySqlHelper.ExecuteNonQuery(sql, dic6);

                MessageBox.Show("还书完成!", "提示");

                // 刷新借书单
                ShowBorrowList();
            }
        }
    }
}
