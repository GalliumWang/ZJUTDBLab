namespace 高校成绩管理系统
{
    partial class 学生修改密码
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
            this.学号 = new System.Windows.Forms.Label();
            this.原密码 = new System.Windows.Forms.Label();
            this.修改密码 = new System.Windows.Forms.Label();
            this.确认密码 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.修改 = new System.Windows.Forms.Button();
            this.退出 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 学号
            // 
            this.学号.AutoSize = true;
            this.学号.BackColor = System.Drawing.Color.Transparent;
            this.学号.Location = new System.Drawing.Point(100, 69);
            this.学号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(37, 15);
            this.学号.TabIndex = 0;
            this.学号.Text = "学号";
            // 
            // 原密码
            // 
            this.原密码.AutoSize = true;
            this.原密码.BackColor = System.Drawing.Color.Transparent;
            this.原密码.Location = new System.Drawing.Point(100, 111);
            this.原密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.原密码.Name = "原密码";
            this.原密码.Size = new System.Drawing.Size(52, 15);
            this.原密码.TabIndex = 1;
            this.原密码.Text = "原密码";
            // 
            // 修改密码
            // 
            this.修改密码.AutoSize = true;
            this.修改密码.BackColor = System.Drawing.Color.Transparent;
            this.修改密码.Location = new System.Drawing.Point(100, 158);
            this.修改密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.修改密码.Name = "修改密码";
            this.修改密码.Size = new System.Drawing.Size(67, 15);
            this.修改密码.TabIndex = 2;
            this.修改密码.Text = "修改密码";
            // 
            // 确认密码
            // 
            this.确认密码.AutoSize = true;
            this.确认密码.BackColor = System.Drawing.Color.Transparent;
            this.确认密码.Location = new System.Drawing.Point(100, 201);
            this.确认密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.确认密码.Name = "确认密码";
            this.确认密码.Size = new System.Drawing.Size(67, 15);
            this.确认密码.TabIndex = 3;
            this.确认密码.Text = "确认密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 154);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(132, 25);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(216, 198);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(132, 25);
            this.textBox4.TabIndex = 7;
            // 
            // 修改
            // 
            this.修改.Location = new System.Drawing.Point(103, 252);
            this.修改.Margin = new System.Windows.Forms.Padding(4);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(100, 29);
            this.修改.TabIndex = 8;
            this.修改.Text = "修改";
            this.修改.UseVisualStyleBackColor = true;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 退出
            // 
            this.退出.Location = new System.Drawing.Point(248, 251);
            this.退出.Margin = new System.Windows.Forms.Padding(4);
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(100, 29);
            this.退出.TabIndex = 9;
            this.退出.Text = "返回";
            this.退出.UseVisualStyleBackColor = true;
            this.退出.Click += new System.EventHandler(this.button2_Click);
            // 
            // 学生修改密码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(448, 331);
            this.Controls.Add(this.退出);
            this.Controls.Add(this.修改);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.确认密码);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.原密码);
            this.Controls.Add(this.学号);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "学生修改密码";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生修改密码";
            this.Load += new System.EventHandler(this.学生修改密码_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 学号;
        private System.Windows.Forms.Label 原密码;
        private System.Windows.Forms.Label 修改密码;
        private System.Windows.Forms.Label 确认密码;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.Button 退出;
    }
}