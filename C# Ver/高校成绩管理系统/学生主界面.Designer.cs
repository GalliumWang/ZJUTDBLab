namespace 高校成绩管理系统
{
    partial class 学生主界面
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
            this.个人信息 = new System.Windows.Forms.Button();
            this.修改密码 = new System.Windows.Forms.Button();
            this.成绩查询 = new System.Windows.Forms.Button();
            this.退出登录 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // 个人信息
            // 
            this.个人信息.Location = new System.Drawing.Point(117, 86);
            this.个人信息.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.个人信息.Name = "个人信息";
            this.个人信息.Size = new System.Drawing.Size(132, 29);
            this.个人信息.TabIndex = 0;
            this.个人信息.Text = "个人信息";
            this.个人信息.UseVisualStyleBackColor = true;
            this.个人信息.Click += new System.EventHandler(this.button1_Click);
            // 
            // 修改密码
            // 
            this.修改密码.Location = new System.Drawing.Point(117, 182);
            this.修改密码.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.修改密码.Name = "修改密码";
            this.修改密码.Size = new System.Drawing.Size(132, 29);
            this.修改密码.TabIndex = 2;
            this.修改密码.Text = "修改密码";
            this.修改密码.UseVisualStyleBackColor = true;
            this.修改密码.Click += new System.EventHandler(this.button2_Click);
            // 
            // 成绩查询
            // 
            this.成绩查询.Location = new System.Drawing.Point(117, 135);
            this.成绩查询.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.成绩查询.Name = "成绩查询";
            this.成绩查询.Size = new System.Drawing.Size(132, 29);
            this.成绩查询.TabIndex = 1;
            this.成绩查询.Text = "成绩查询";
            this.成绩查询.UseVisualStyleBackColor = true;
            this.成绩查询.Click += new System.EventHandler(this.button4_Click);
            // 
            // 退出登录
            // 
            this.退出登录.Location = new System.Drawing.Point(117, 231);
            this.退出登录.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.退出登录.Name = "退出登录";
            this.退出登录.Size = new System.Drawing.Size(132, 29);
            this.退出登录.TabIndex = 3;
            this.退出登录.Text = "退出登录";
            this.退出登录.UseVisualStyleBackColor = true;
            this.退出登录.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 学生主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(379, 328);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.退出登录);
            this.Controls.Add(this.成绩查询);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.个人信息);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "学生主界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生主界面";
            this.Load += new System.EventHandler(this.学生主界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 个人信息;
        private System.Windows.Forms.Button 修改密码;
        private System.Windows.Forms.Button 成绩查询;
        private System.Windows.Forms.Button 退出登录;
        private System.Windows.Forms.TextBox textBox1;
    }
}