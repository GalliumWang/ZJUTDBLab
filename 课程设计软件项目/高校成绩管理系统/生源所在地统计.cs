using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高校成绩管理系统
{
    public partial class 生源所在地统计 : Form
    {
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        public 生源所在地统计()
        {
            InitializeComponent();
            try
            {
                sql = "select wjt_生源所在地24 as 生源所在地,wjt_总数 as 总数 FROM wangjt_生源所在地统计表24";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行此操作", "提示", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            管理员主界面 manager = new 管理员主界面();
            manager.Show();
            this.Hide();
        }//退出生源查询

        private void 生源所在地统计_Load(object sender, EventArgs e)
        {

        }
    }
}
