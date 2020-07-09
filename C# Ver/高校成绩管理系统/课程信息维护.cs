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
    public partial class 课程信息维护 : Form
    {
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select * from wangjt_课程24";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 课程信息维护()
        {
            InitializeComponent();
            SetBind();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into wangjt_课程24 values('" + textBox1.Text + "','" + textBox2.Text + "','" + combobox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "')";
                con.OperateDate(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cannel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要返回主界面吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                管理员主界面 manager = new 管理员主界面();
                manager.Show();
                this.Hide();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from wangjt_课程24 where wjt_课程编号24 = '" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateDate(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 性别_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 课程信息维护_Load(object sender, EventArgs e)
        {

        }
    }
}
