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
    public partial class 教师个人信息 : Form
    {
        string Tno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        DataSet InfTab;
        public 教师个人信息(string tTno)
        {
            InitializeComponent();
            Tno = tTno;
            sql = "SELECT wjt_姓名24,wjt_性别24,wjt_年龄24,wjt_教师编号24,wjt_教师职称24,wjt_联系电话24 FROM wangjt_教师24 WHERE wangjt_教师24.wjt_教师编号24='" + Tno + "'";
            InfTab = con.Getds(sql);
            textBox1.Text = InfTab.Tables[0].Rows[0][0].ToString();
            textBox2.Text = InfTab.Tables[0].Rows[0][1].ToString();
            textBox3.Text = InfTab.Tables[0].Rows[0][2].ToString();
            textBox4.Text = InfTab.Tables[0].Rows[0][3].ToString();
            textBox5.Text = InfTab.Tables[0].Rows[0][4].ToString();
            textBox6.Text = InfTab.Tables[0].Rows[0][5].ToString();
        }

        private void 教师个人信息_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void 确认_Click(object sender, EventArgs e)
        {
            教师主界面 teacher = new 教师主界面(Tno);
            teacher.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
