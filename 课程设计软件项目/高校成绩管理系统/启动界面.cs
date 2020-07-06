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
    public partial class 启动界面 : Form
    {
        public 启动界面()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string serverString = textBox1.Text;
                serverName.serverString = serverString;
                连接数据库 conn = new 连接数据库();
                登陆界面 temp = new 登陆界面();
                temp.Show();
                this.Hide();

            }
            catch
            {

                MessageBox.Show("连接失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serverName.serverString = "";

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
