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
    public partial class 教师查询学生成绩 : Form
    {
        string Tno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "SELECT *,row_number()over(partition by wjt_课程名称24 order by wjt_成绩24 desc) 单科排名 FROM wangjt_学生成绩信息表24 order by wjt_开课学期24 desc, wjt_姓名24";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 教师查询学生成绩(string tTno)
        {
            Tno = tTno;
            InitializeComponent();
            SetBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            教师主界面 teacher = new 教师主界面(Tno);
            teacher.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 教师查询学生成绩_Load(object sender, EventArgs e)
        {

        }
    }
}
