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
    public partial class 教师输入学生成绩 : Form
    {
        string Tno;
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select * from wangjt_成绩24";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 教师输入学生成绩(string tTno)
        {
            InitializeComponent();
            SetBind();
            Tno = tTno;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            教师主界面 teacher = new 教师主界面(Tno);
            teacher.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from wangjt_成绩24 where wjt_学号24 = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateDate(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into wangjt_成绩24 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                con.OperateDate(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 教师输入学生成绩_Load(object sender, EventArgs e)
        {

        }
    }
}
