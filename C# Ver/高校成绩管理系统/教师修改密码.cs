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
    public partial class 教师修改密码 : Form
    {
        string Tno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        public 教师修改密码(string tTno)
        {
            InitializeComponent();
            Tno = tTno;
            textBox1.Text = Tno;
        }

        private void 学号_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要返回主界面吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                教师主界面 teacher = new 教师主界面(Tno);
                teacher.Show();
                this.Hide();
            }

        }

        private void 修改_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请按照要求正确输入！！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string temp = "wangjt_教师登录24";
            连接数据库 conn = new 连接数据库();
            if (conn.getPass(textBox1.Text, textBox2.Text, temp, "教师编号"))
            {
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("两次密码输入不同请重新输入！！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "UPDATE wangjt_教师登录24 SET wjt_密码24='" + textBox3.Text + "' WHERE wjt_教师编号24='" + Tno + "'";
                    连接数据库 uppassword = new 连接数据库();
                    uppassword.OperateDate(sql);
                    MessageBox.Show("密码修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    登陆界面 login = new 登陆界面();
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("密码输入错误！！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 确认密码_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码_Click(object sender, EventArgs e)
        {

        }

        private void 原密码_Click(object sender, EventArgs e)
        {

        }

        private void 退出_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要返回主界面吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                教师主界面 teacher = new 教师主界面(Tno);
                teacher.Show();
                this.Hide();
            }
        }

        private void 教师修改密码_Load(object sender, EventArgs e)
        {

        }
    }
}
