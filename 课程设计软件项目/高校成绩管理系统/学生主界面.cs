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
    public partial class 学生主界面 : Form
    {
        string Sno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        public 学生主界面(string tSno)
        {
            InitializeComponent();
            Sno = tSno;
            sql = "SELECT wjt_姓名24 FROM wangjt_学生24 WHERE wjt_学号24='" + Sno +"' ";
            DataSet InfTab = con.Getds(sql);
            textBox1.Text = "欢迎你，" + InfTab.Tables[0].Rows[0][0].ToString();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 学生主界面_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            学生修改密码 UpStuMassage = new 学生修改密码(Sno);
            UpStuMassage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            学生个人信息 StuMessage = new 学生个人信息(Sno);
            StuMessage.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要返回登陆界面吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                登陆界面 login = new 登陆界面();
                this.Hide();
                login.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            学生成绩查询 StuGrage = new 学生成绩查询(Sno);
            StuGrage.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
