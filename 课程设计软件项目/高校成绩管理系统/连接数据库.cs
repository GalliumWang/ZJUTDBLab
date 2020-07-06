using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 高校成绩管理系统
{
    class 连接数据库
    {
        public SqlConnection conn = null;
        public 连接数据库()
        {
            if (conn == null)
            {
                string connCmd1="Data Source = ";
                string tempServerName =serverName.serverString;
                string connCmd2 = ";database = wangjiaMis24;Trusted_Connection=SSPI";
                conn = new SqlConnection(connCmd1+tempServerName+connCmd2);
                //conn = new SqlConnection("Data Source = GALLIUM-WANG\\GALLIUMMSQL;database = wangjiaMis24;Trusted_Connection=SSPI");
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
        }

        public void closeConnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }//关闭数据库连接

        public DataSet Getds(string sql)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            return ds;
        }//执行sql语句并将获得数据存入DataSet中并返回

        public int OperateDate(string sql)//直接执行sql命令
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.Connection = conn;
            int x = sqlcom.ExecuteNonQuery();
            conn.Close();
            return x;
        }

        public DataSet BindDataGridView(DataGridView dgv, string sql)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            return ds;
        }//将sql执行结果存储在表格中

        public bool getPass(string userid, string upwd, string ts, string temp1)
        {
            bool result = false;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "SELECT * FROM " + ts + " WHERE wjt_" + temp1 + "24='" + userid + "' AND wjt_密码24='" + upwd + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                result = false;
            }
            else
                result = true;
            return result;
        }
    }
}
