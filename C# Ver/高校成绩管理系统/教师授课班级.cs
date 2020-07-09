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
    public partial class 教师授课班级 : Form
    {
        string Tno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        public 教师授课班级(string tTno)
        {
            InitializeComponent();
            Tno = tTno;
            try
            {
                sql = "select distinct wjt_课程名称24 as 课程,wjt_开课学期24 as 开课时间,wjt_学分24 as 学分,wjt_学时24 as 学时,wjt_考核方式24 as 考核,wjt_班级名称24 as 班级 from wangjt_课程24,wangjt_班级24,wangjt_课程开设24 where wjt_教师编号24='" + Tno + "'and wangjt_课程开设24.wjt_课程编号24=wangjt_课程24.wjt_课程编号24 and wangjt_课程开设24.wjt_班级编号24=wangjt_班级24.wjt_班级编号24";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行此操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 教师授课班级_Load(object sender, EventArgs e)
        {

        }

        private void 确定_Click(object sender, EventArgs e)
        {
            教师主界面 teacher = new 教师主界面(Tno);
            teacher.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
