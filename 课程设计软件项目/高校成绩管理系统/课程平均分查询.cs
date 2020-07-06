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
    public partial class 课程平均分查询 : Form
    {
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        public 课程平均分查询()
        {
            InitializeComponent();
            try
            {
                sql = "select wjt_课程名称24 as 课程名称,wjt_平均成绩24 as 平均成绩 FROM wangjt_课程平均成绩表24";
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

        private void button1_Click(object sender, EventArgs e)
        {
            管理员主界面 manager = new 管理员主界面();
            manager.Show();
            this.Hide();
        }

        private void 课程平均分查询_Load(object sender, EventArgs e)
        {

        }
    }
}
