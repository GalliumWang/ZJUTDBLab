using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高校成绩管理系统
{
    public partial class 登陆界面 : Form
    {
        public 登陆界面()
        {
            InitializeComponent();
        }//构造函数

        private void 登陆界面_Load(object sender, EventArgs e)
        {
        
        }


        private void 确定_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPwd.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请按照要求正确输入！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (comboBox1.SelectedItem.ToString().Equals("学  生"))
                {
                    string temp = "wangjt_学生登录24";
                    连接数据库 conn = new 连接数据库();
                    if (conn.getPass(txtName.Text, txtPwd.Text, temp, "学号"))
                    {
                        学生主界面 student = new 学生主界面(txtName.Text);
                        student.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("账号或密码错误！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (comboBox1.SelectedItem.ToString().Equals("教  师"))
                {
                    string temp = "wangjt_教师登录24";
                    连接数据库 conn = new 连接数据库();
                    if (conn.getPass(txtName.Text, txtPwd.Text, temp, "教师编号"))
                    {
                        教师主界面 teacher = new 教师主界面(txtName.Text);
                        teacher.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("账号或密码错误！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (comboBox1.SelectedItem.ToString().Equals("管理员"))
                {
                    string temp = "wangjt_管理员登录24";
                    连接数据库 conn = new 连接数据库();
                    if (conn.getPass(txtName.Text, txtPwd.Text, temp, "管理员账号"))
                    {
                        管理员主界面 manager = new 管理员主界面();
                        manager.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("账号或密码错误！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //this.Dispose();
                Application.Exit();
            }
            
        }//退出程序


        /*
         空方法
         */


        private void 密码_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
