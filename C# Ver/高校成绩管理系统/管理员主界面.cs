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
    public partial class 管理员主界面 : Form
    {
        public 管理员主界面()
        {
            InitializeComponent();
        }

        private void 管理员主界面_Load(object sender, EventArgs e)
        {

        }

        private void 生源所在地查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            生源所在地统计 StuPlace = new 生源所在地统计();
            StuPlace.Show();
            this.Hide();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要退出登录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                登陆界面 login = new 登陆界面();
                login.Show();
                this.Hide();
            }
        }

        private void 班级平均分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            课程平均分查询 ClaGrade = new 课程平均分查询();
            ClaGrade.Show();
            this.Hide();
        }

        private void 全校课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            班级开课查询 SchCourse = new 班级开课查询();
            SchCourse.Show();
            this.Hide();
        }

        private void 添加专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            专业信息维护 deps = new 专业信息维护();
            deps.Show();
            this.Hide();
        }

        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            班级信息维护 Class = new 班级信息维护();
            Class.Show();
            this.Hide();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生信息维护 student = new 学生信息维护();
            student.Show();
            this.Hide();
        }

        private void 教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            教师信息维护 teacher = new 教师信息维护();
            teacher.Show();
            this.Hide();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            课程信息维护 course = new 课程信息维护();
            course.Show();
            this.Hide();
        }


        //一级标题仅提供下拉二级标题，无其他作用实现

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void 课程开设ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            课程开设 course = new 课程开设();
            course.Show();
            this.Hide();
        }
    }
}
