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
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
        }

        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        // pageIndex 标记DGV应该显示第几页
        private int pageIndex;
        // maxIndex 标记DGV的总页数
        int maxIndex;

        private void GetData()
        {
            // 获取页大小
            int pageSize = 10;
            // 计算最多有多少页--Math.Ceiling--向上取整
            // Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books"))得到数据记录总数
            //maxIndex = (int)Math.Ceiling((Convert.ToInt32(MySqlHelper.ExecuteScalar("select count(*) from books")) * 1.0 / pageSize));
            maxIndex = (int)Math.Ceiling((Convert.ToInt32(MySqlHelper.ExecuteScalar("select count(*) from books")) * 1.0));
            // 获取连接字符串
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                // 判断是否有数据
                // Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books"))得到数据记录总数
                if (Convert.ToInt32(MySqlHelper.ExecuteScalar("select count(*) from books")) > 0 && pageIndex > 0)
                {
                    // 确定有数据才进行查询
                    // 创建表格，用来存储数据
                    DataTable dt = new DataTable();
                    // 构造带分页功能的 sql 语句);
                    string sql = string.Format("select bookId, bookName, author, score, press, price, amount from books LIMIT " + pageIndex + ", 10;");
                    // 构造适配器对象
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
                    // 传递参数
                    // 本页第一条数据
                    //adapter.SelectCommand.Parameters.AddWithValue("@sIndex", ((pageIndex - 1) * pageSize + 1));
                    // 本页最后一条数据
                    //adapter.SelectCommand.Parameters.AddWithValue("@eIndex", pageIndex * pageSize);
                    // 执行查询
                    adapter.Fill(dt);
                    SearchBookDataGridView.DataSource = dt;
                }
                else if (pageIndex <= 0)
                {
                    pageIndex = 1;
                }
                else
                {
                    MessageBox.Show("没有获取到数据！", "警告");
                }
            }
        }
        private void SearchBookForm_Load(object sender, EventArgs e)
        {
            if (_Tag == "user")
            {
                SearchBookDataGridView.ReadOnly = true;
            }
            pageIndex = 1;
            GetData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select bookId, bookName, author, score, press, price, amount from books where bookName like '%" + SearchBookNameTextBox.Text.Trim() + "%'");
            DataTable dt = MySqlHelper.GetList(sql);
            this.SearchBookDataGridView.DataSource = dt;

            /*
            string sql = "select bookId, bookName, author, score, press, price, amount from books where bookName like '%@bookName%'";
            MyDictionary dic = new MyDictionary();
            dic.Add("@bookName", SearchBookNameTextBox.Text.Trim());
            DataTable dt = MySqlHelper.GetList(sql, dic);
            this.SearchBookDataGridView.DataSource = dt;
            */

            /* 可行
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";
            string sql = string.Format("select bookId, bookName, author, score, press, price, amount from books where bookName like '%" + SearchBookNameTextBox.Text.Trim() + "%'");
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.SearchBookDataGridView.DataSource = dt;
            */
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }

        private void HomePageToolStripButton_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetData();
        }

        private void PrePageToolStripButton_Click(object sender, EventArgs e)
        {
            pageIndex = pageIndex - 10;
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }

        private void NextPageToolStripButton_Click(object sender, EventArgs e)
        {
            pageIndex = pageIndex + 10;
            if (pageIndex >= maxIndex)
            {
                pageIndex = pageIndex - 10;
                MessageBox.Show("到底啦 ！", "提示");
            }
            GetData();
        }

        private void LastPageToolStripButton_Click(object sender, EventArgs e)
        {
            pageIndex = maxIndex - 10;
            GetData();
        }

        private void SearchBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
