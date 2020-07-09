namespace 高校成绩管理系统
{
    partial class 教师主界面
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.个人信息 = new System.Windows.Forms.Button();
            this.授课班级 = new System.Windows.Forms.Button();
            this.修改密码 = new System.Windows.Forms.Button();
            this.退出登录 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 个人信息
            // 
            this.个人信息.Location = new System.Drawing.Point(104, 75);
            this.个人信息.Margin = new System.Windows.Forms.Padding(4);
            this.个人信息.Name = "个人信息";
            this.个人信息.Size = new System.Drawing.Size(133, 29);
            this.个人信息.TabIndex = 0;
            this.个人信息.Text = "个人信息";
            this.个人信息.UseVisualStyleBackColor = true;
            this.个人信息.Click += new System.EventHandler(this.个人信息_Click);
            // 
            // 授课班级
            // 
            this.授课班级.Location = new System.Drawing.Point(104, 128);
            this.授课班级.Margin = new System.Windows.Forms.Padding(4);
            this.授课班级.Name = "授课班级";
            this.授课班级.Size = new System.Drawing.Size(133, 29);
            this.授课班级.TabIndex = 1;
            this.授课班级.Text = "授课班级";
            this.授课班级.UseVisualStyleBackColor = true;
            this.授课班级.Click += new System.EventHandler(this.授课班级_Click);
            // 
            // 修改密码
            // 
            this.修改密码.Location = new System.Drawing.Point(103, 293);
            this.修改密码.Margin = new System.Windows.Forms.Padding(4);
            this.修改密码.Name = "修改密码";
            this.修改密码.Size = new System.Drawing.Size(133, 29);
            this.修改密码.TabIndex = 3;
            this.修改密码.Text = "修改密码";
            this.修改密码.UseVisualStyleBackColor = true;
            this.修改密码.Click += new System.EventHandler(this.修改密码_Click);
            // 
            // 退出登录
            // 
            this.退出登录.Location = new System.Drawing.Point(104, 349);
            this.退出登录.Margin = new System.Windows.Forms.Padding(4);
            this.退出登录.Name = "退出登录";
            this.退出登录.Size = new System.Drawing.Size(133, 29);
            this.退出登录.TabIndex = 4;
            this.退出登录.Text = "退出登录";
            this.退出登录.UseVisualStyleBackColor = true;
            this.退出登录.Click += new System.EventHandler(this.退出登录_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "成绩输入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 236);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "成绩查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 教师主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(355, 413);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.退出登录);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.授课班级);
            this.Controls.Add(this.个人信息);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "教师主界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师主界面";
            this.Load += new System.EventHandler(this.教师主界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 个人信息;
        private System.Windows.Forms.Button 授课班级;
        private System.Windows.Forms.Button 修改密码;
        private System.Windows.Forms.Button 退出登录;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}