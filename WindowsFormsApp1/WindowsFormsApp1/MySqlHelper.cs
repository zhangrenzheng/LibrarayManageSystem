using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class MySqlHelper
    {
        public static bool IsUserExists(string userId)
        {
            bool isExists = false;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "select count(*) from users where userId = @userId";
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                myCommand.Parameters.Add(new MySqlParameter("@userId", userId));
                conn.Open();
                int obj = Convert.ToInt32(myCommand.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }

        public static bool IsBookExistsWithName(string bookName)
        {
            bool isExists = false;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "select count(*) from books where bookName = @bookName";
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                myCommand.Parameters.Add(new MySqlParameter("@bookName", bookName));
                conn.Open();
                int obj = Convert.ToInt32(myCommand.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }
        public static bool IsBookExistsWithId(string bookId)
        {
            bool isExists = false;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "select count(*) from books where bookId = @bookId";
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                myCommand.Parameters.Add(new MySqlParameter("@bookId", bookId));
                conn.Open();
                int obj = Convert.ToInt32(myCommand.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }
        private static int ExecuteNonQuery(string sql, CommandType type, params MySqlParameter[] ps)
        {
            int rows = -1;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                myCommand.CommandType = type;               // 存储过程 type为StoredProcedure
                myCommand.Parameters.AddRange(ps);
                conn.Open();
                rows = myCommand.ExecuteNonQuery();
            }

            return rows;
        }
        public static int ExecuteNonQuery(string sql, MyDictionary dic)
        {
            MySqlParameter[] ps = new MySqlParameter[dic.Count];
            int index = 0;
            foreach (var item in dic)
            {
                ps[index++] = new MySqlParameter(item.Key, item.Value);
            }
            return ExecuteNonQuery(sql, CommandType.Text, ps);
        }
        public static int ExecuteNonQuery(string sql, CommandType type, MyDictionary dic)
        {
            MySqlParameter[] ps = new MySqlParameter[dic.Count];
            int index = 0;
            foreach (var item in dic)
            {
                ps[index++] = new MySqlParameter(item.Key, item.Value);
            }
            return ExecuteNonQuery(sql, type, ps);
        }

        public static int ExecuteNonQuery(string sql)
        {
            int rows = -1;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                conn.Open();
                rows = myCommand.ExecuteNonQuery();
            }

            return rows;
        }

        // 执行sql语句 返回首行首列
        public static object ExecuteScalar(string sql)
        {
            object obj = null;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                conn.Open();
                obj = myCommand.ExecuteScalar();
            }
            return obj;
        }
        public static object ExecuteScalar(string sql, CommandType type, MyDictionary dic)
        {
            object obj = null;
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                myCommand.CommandType = type;

                //构造参数
                MySqlParameter[] ps = new MySqlParameter[dic.Count];
                int index = 0;
                foreach (var item in dic)
                {
                    ps[index++] = new MySqlParameter(item.Key, item.Value);
                }
                myCommand.Parameters.AddRange(ps);
                //执行命令
                conn.Open();
                obj = myCommand.ExecuteScalar();
            }
            return obj;
        }
        public static object ExecuteScalar(string sql, MyDictionary dic)
        {
            return ExecuteScalar(sql, CommandType.Text, dic);
        }



       
        // 执行查询  返回结果集DataTable  获取列表
        public static DataTable GetList(string sql)
        {
            // 构造数据表，用于存储查询的数据
            DataTable dt = new DataTable();
            // 创建连接对象
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
            adapter.Fill(dt);
            return dt;
        }


        /* 
        // 执行查询  返回结果集DataTable  获取列表
        public static DataTable GetList(string sql, MyDictionary dic)
        {
            // 构造数据表，用于存储查询的数据
            DataTable dt = new DataTable();
            // 创建连接对象
            string connectString = "server=localhost;User Id=root;password=123456;Database=library;";

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                // 执行命令
                MySqlCommand myCommand = new MySqlCommand(sql, conn);
                // 构造参数
                MySqlParameter[] ps = new MySqlParameter[dic.Count];
                int index = 0;
                foreach (var item in dic)
                {
                    ps[index++] = new MySqlParameter(item.Key, item.Value);
                }
                myCommand.Parameters.AddRange(ps);
                // 执行命令
                MySqlDataAdapter adapter = new MySqlDataAdapter(myCommand);
                adapter.Fill(dt);
            }
            return dt;
        }
        */
    }
}
