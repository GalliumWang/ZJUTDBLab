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
    public partial class 学生修改密码 : Form
    {
        string Sno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        public 学生修改密码(string tSno)
        {
            InitializeComponent();
            Sno = tSno;
            textBox1.Text = Sno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要返回主界面吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                学生主界面 student = new 学生主界面(Sno);
                student.Show();
                this.Hide();
            }
        }

        private void 学生修改密码_Load(object sender, EventArgs e)
        {

        }

        private void 修改_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请按照要求正确输入！！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string temp = "wangjt_学生登录24";
            连接数据库 conn = new 连接数据库();

            if (conn.getPass(textBox1.Text, textBox2.Text, temp, "学号"))
            {
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("两次密码输入不同请重新输入！！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "UPDATE wangjt_学生登录24 SET wjt_密码24='" + textBox3.Text + "' WHERE wjt_学号24='" + Sno + "'";
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
