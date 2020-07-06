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
    public partial class 学生成绩查询 : Form
    {
        string Sno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        DataSet dx;
        public 学生成绩查询(string tSno)
        {
            InitializeComponent();
            Sno = tSno;
            t学号.Text = Sno;
            sql = "SELECT wjt_已修学分24 FROM wangjt_学生24 WHERE wjt_学号24='" + Sno + "'";
            dx = con.Getds(sql);
            t学分.Text = dx.Tables[0].Rows[0][0].ToString();
            sql = "select wjt_课程名称24 as 课程,wjt_开课学期24 as 时间,wjt_学分24 as 学分,wjt_学时24 as 学时,wjt_成绩24 as 成绩 from wangjt_学生24,wangjt_成绩24,wangjt_课程24 WHERE wangjt_学生24.wjt_学号24='" + Sno + "'and wangjt_学生24.wjt_学号24=wangjt_成绩24.wjt_学号24 and wangjt_成绩24.wjt_课程编号24=wangjt_课程24.wjt_课程编号24";
            con.BindDataGridView(dataGridView1, sql);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void 学生成绩查询_Load(object sender, EventArgs e)
        {

        }

        private void 退出_Click(object sender, EventArgs e)
        {
                学生主界面 student = new 学生主界面(Sno);
                student.Show();
                this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
