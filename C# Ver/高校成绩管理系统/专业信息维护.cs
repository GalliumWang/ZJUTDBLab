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
    public partial class 专业信息维护 : Form
    {
        连接数据库 con = new 连接数据库();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select wjt_专业编号24 as 专业编号,wjt_专业名称24 as 专业名称 from wangjt_专业24";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 专业信息维护()
        {
            InitializeComponent();
            SetBind();
        }

        private void 年级信息录入_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into wangjt_专业24 values('" + txtDno.Text + "','" + txtName.Text + "')";
                con.OperateDate(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from wangjt_专业24 where wjt_专业编号24 = '" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateDate(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update wangjt_专业24 set wjt_专业名称24 = '" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'where wjt_专业编号24'" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateDate(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("无法进行该操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
