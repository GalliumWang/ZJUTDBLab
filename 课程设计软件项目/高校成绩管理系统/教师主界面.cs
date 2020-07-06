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
    public partial class 教师主界面 : Form
    {
        string Tno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        public 教师主界面(string tTno)
        {
            InitializeComponent();
            Tno = tTno;
            sql = "SELECT wjt_姓名24 FROM wangjt_教师24 WHERE wjt_教师编号24='" + Tno + "' ";
            DataSet InfTab = con.Getds(sql);
            textBox1.Text = "欢迎你，" + InfTab.Tables[0].Rows[0][0].ToString();
        }

        private void 教师主界面_Load(object sender, EventArgs e)
        {

        }

        private void 个人信息_Click(object sender, EventArgs e)
        {
            教师个人信息 TeaMessage = new 教师个人信息(Tno);
            TeaMessage.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 退出登录_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要返回登陆界面吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                登陆界面 login = new 登陆界面();
                this.Hide();
                login.Show();
            }
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            教师修改密码 UpTeaMassage = new 教师修改密码(Tno);
            UpTeaMassage.Show();
            this.Hide();
        }

        private void 授课班级_Click(object sender, EventArgs e)
        {
            教师授课班级 TeaClass = new 教师授课班级(Tno);
            TeaClass.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            教师输入学生成绩 TeaClass = new 教师输入学生成绩(Tno);
            TeaClass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            教师查询学生成绩 TeaClass = new 教师查询学生成绩(Tno);
            TeaClass.Show();
            this.Hide();
        }
    }
}
