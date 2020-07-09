namespace 高校成绩管理系统
{
    partial class 学生个人信息
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.姓名 = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.年龄 = new System.Windows.Forms.Label();
            this.学号 = new System.Windows.Forms.Label();
            this.已修学分 = new System.Windows.Forms.Label();
            this.班级名称 = new System.Windows.Forms.Label();
            this.生源所在地 = new System.Windows.Forms.Label();
            this.t姓名 = new System.Windows.Forms.TextBox();
            this.t已修学分 = new System.Windows.Forms.TextBox();
            this.t生源所在地 = new System.Windows.Forms.TextBox();
            this.t班级名称 = new System.Windows.Forms.TextBox();
            this.t学号 = new System.Windows.Forms.TextBox();
            this.t年龄 = new System.Windows.Forms.TextBox();
            this.t性别 = new System.Windows.Forms.TextBox();
            this.确定 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.BackColor = System.Drawing.Color.Transparent;
            this.姓名.Location = new System.Drawing.Point(68, 39);
            this.姓名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(37, 15);
            this.姓名.TabIndex = 1;
            this.姓名.Text = "姓名";
            this.姓名.Click += new System.EventHandler(this.label1_Click);
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.BackColor = System.Drawing.Color.Transparent;
            this.性别.Location = new System.Drawing.Point(68, 72);
            this.性别.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(37, 15);
            this.性别.TabIndex = 3;
            this.性别.Text = "性别";
            this.性别.Click += new System.EventHandler(this.学号_Click);
            // 
            // 年龄
            // 
            this.年龄.AutoSize = true;
            this.年龄.BackColor = System.Drawing.Color.Transparent;
            this.年龄.Location = new System.Drawing.Point(68, 106);
            this.年龄.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.年龄.Name = "年龄";
            this.年龄.Size = new System.Drawing.Size(37, 15);
            this.年龄.TabIndex = 5;
            this.年龄.Text = "年龄";
            // 
            // 学号
            // 
            this.学号.AutoSize = true;
            this.学号.BackColor = System.Drawing.Color.Transparent;
            this.学号.Location = new System.Drawing.Point(68, 140);
            this.学号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(37, 15);
            this.学号.TabIndex = 7;
            this.学号.Text = "学号";
            // 
            // 已修学分
            // 
            this.已修学分.AutoSize = true;
            this.已修学分.BackColor = System.Drawing.Color.Transparent;
            this.已修学分.Location = new System.Drawing.Point(68, 174);
            this.已修学分.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.已修学分.Name = "已修学分";
            this.已修学分.Size = new System.Drawing.Size(67, 15);
            this.已修学分.TabIndex = 9;
            this.已修学分.Text = "已修学分";
            this.已修学分.Click += new System.EventHandler(this.label5_Click);
            // 
            // 班级名称
            // 
            this.班级名称.AutoSize = true;
            this.班级名称.BackColor = System.Drawing.Color.Transparent;
            this.班级名称.Location = new System.Drawing.Point(68, 208);
            this.班级名称.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.班级名称.Name = "班级名称";
            this.班级名称.Size = new System.Drawing.Size(67, 15);
            this.班级名称.TabIndex = 11;
            this.班级名称.Text = "班级名称";
            // 
            // 生源所在地
            // 
            this.生源所在地.AutoSize = true;
            this.生源所在地.BackColor = System.Drawing.Color.Transparent;
            this.生源所在地.Location = new System.Drawing.Point(68, 241);
            this.生源所在地.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.生源所在地.Name = "生源所在地";
            this.生源所在地.Size = new System.Drawing.Size(82, 15);
            this.生源所在地.TabIndex = 13;
            this.生源所在地.Text = "生源所在地";
            // 
            // t姓名
            // 
            this.t姓名.Location = new System.Drawing.Point(163, 35);
            this.t姓名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t姓名.Name = "t姓名";
            this.t姓名.Size = new System.Drawing.Size(173, 25);
            this.t姓名.TabIndex = 2;
            this.t姓名.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // t已修学分
            // 
            this.t已修学分.Location = new System.Drawing.Point(163, 170);
            this.t已修学分.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t已修学分.Name = "t已修学分";
            this.t已修学分.Size = new System.Drawing.Size(173, 25);
            this.t已修学分.TabIndex = 10;
            // 
            // t生源所在地
            // 
            this.t生源所在地.Location = new System.Drawing.Point(163, 238);
            this.t生源所在地.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t生源所在地.Name = "t生源所在地";
            this.t生源所在地.Size = new System.Drawing.Size(173, 25);
            this.t生源所在地.TabIndex = 14;
            // 
            // t班级名称
            // 
            this.t班级名称.Location = new System.Drawing.Point(163, 204);
            this.t班级名称.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t班级名称.Name = "t班级名称";
            this.t班级名称.Size = new System.Drawing.Size(173, 25);
            this.t班级名称.TabIndex = 12;
            this.t班级名称.TextChanged += new System.EventHandler(this.t班级编号_TextChanged);
            // 
            // t学号
            // 
            this.t学号.Location = new System.Drawing.Point(163, 136);
            this.t学号.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t学号.Name = "t学号";
            this.t学号.Size = new System.Drawing.Size(173, 25);
            this.t学号.TabIndex = 8;
            // 
            // t年龄
            // 
            this.t年龄.Location = new System.Drawing.Point(163, 102);
            this.t年龄.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t年龄.Name = "t年龄";
            this.t年龄.Size = new System.Drawing.Size(173, 25);
            this.t年龄.TabIndex = 6;
            // 
            // t性别
            // 
            this.t性别.Location = new System.Drawing.Point(163, 69);
            this.t性别.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t性别.Name = "t性别";
            this.t性别.Size = new System.Drawing.Size(173, 25);
            this.t性别.TabIndex = 4;
            this.t性别.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(132, 284);
            this.确定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(100, 29);
            this.确定.TabIndex = 0;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.button1_Click);
            // 
            // 学生个人信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(379, 328);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.t性别);
            this.Controls.Add(this.t年龄);
            this.Controls.Add(this.t学号);
            this.Controls.Add(this.t班级名称);
            this.Controls.Add(this.t生源所在地);
            this.Controls.Add(this.t已修学分);
            this.Controls.Add(this.t姓名);
            this.Controls.Add(this.生源所在地);
            this.Controls.Add(this.班级名称);
            this.Controls.Add(this.已修学分);
            this.Controls.Add(this.学号);
            this.Controls.Add(this.年龄);
            this.Controls.Add(this.性别);
            this.Controls.Add(this.姓名);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "学生个人信息";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生个人信息";
            this.Load += new System.EventHandler(this.学生个人信息查询_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.Label 年龄;
        private System.Windows.Forms.Label 学号;
        private System.Windows.Forms.Label 已修学分;
        private System.Windows.Forms.Label 班级名称;
        private System.Windows.Forms.Label 生源所在地;
        private System.Windows.Forms.TextBox t姓名;
        private System.Windows.Forms.TextBox t已修学分;
        private System.Windows.Forms.TextBox t生源所在地;
        private System.Windows.Forms.TextBox t班级名称;
        private System.Windows.Forms.TextBox t学号;
        private System.Windows.Forms.TextBox t年龄;
        private System.Windows.Forms.TextBox t性别;
        private System.Windows.Forms.Button 确定;
    }
}