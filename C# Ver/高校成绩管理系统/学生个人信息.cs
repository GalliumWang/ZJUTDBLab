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
    public partial class 学生个人信息 : Form
    {
        string Sno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        DataSet InfTab;
        public 学生个人信息(string tSno)
        {
            InitializeComponent();
            Sno = tSno;
            sql = "SELECT wangjt_学生24.wjt_姓名24,wjt_性别24,wjt_年龄24,wjt_学号24,wjt_班级名称24,wjt_已修学分24,wjt_生源所在地24 FROM wangjt_学生24,wangjt_班级24 WHERE wangjt_学生24.wjt_学号24='" + Sno + "' AND wangjt_学生24.wjt_班级编号24=wangjt_班级24.wjt_班级编号24";
            InfTab = con.Getds(sql);
            t姓名.Text = InfTab.Tables[0].Rows[0][0].ToString();
            t性别.Text = InfTab.Tables[0].Rows[0][1].ToString();
            t年龄.Text = InfTab.Tables[0].Rows[0][2].ToString();
            t学号.Text = InfTab.Tables[0].Rows[0][3].ToString();
            t班级名称.Text = InfTab.Tables[0].Rows[0][4].ToString();
            t已修学分.Text = InfTab.Tables[0].Rows[0][5].ToString();
            t生源所在地.Text = InfTab.Tables[0].Rows[0][6].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 学号_Click(object sender, EventArgs e)
        {

        }

        private void 学生个人信息查询_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            学生主界面 student = new 学生主界面(Sno);
            student.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void t班级编号_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
