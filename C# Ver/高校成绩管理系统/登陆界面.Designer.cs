namespace 高校成绩管理系统
{
    partial class 登陆界面
    {
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


        private void InitializeComponent()
        {
            this.用户名 = new System.Windows.Forms.Label();
            this.密码 = new System.Windows.Forms.Label();
            this.登录 = new System.Windows.Forms.Button();
            this.退出 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 用户名
            // 
            this.用户名.AutoSize = true;
            this.用户名.BackColor = System.Drawing.Color.Transparent;
            this.用户名.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户名.Location = new System.Drawing.Point(81, 159);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(67, 15);
            this.用户名.TabIndex = 4;
            this.用户名.Text = "用户名：";
            // 
            // 密码
            // 
            this.密码.AutoSize = true;
            this.密码.BackColor = System.Drawing.Color.Transparent;
            this.密码.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码.Location = new System.Drawing.Point(81, 213);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(68, 15);
            this.密码.TabIndex = 6;
            this.密码.Text = "密  码：";
            this.密码.Click += new System.EventHandler(this.密码_Click);
            // 
            // 登录
            // 
            this.登录.BackColor = System.Drawing.Color.Transparent;
            this.登录.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录.Location = new System.Drawing.Point(73, 271);
            this.登录.Name = "登录";
            this.登录.Size = new System.Drawing.Size(75, 23);
            this.登录.TabIndex = 0;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = false;
            this.登录.Click += new System.EventHandler(this.确定_Click);
            // 
            // 退出
            // 
            this.退出.BackColor = System.Drawing.Color.Transparent;
            this.退出.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出.Location = new System.Drawing.Point(238, 271);
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(75, 23);
            this.退出.TabIndex = 1;
            this.退出.Text = "退出";
            this.退出.UseVisualStyleBackColor = false;
            this.退出.Click += new System.EventHandler(this.取消_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 24);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(167, 210);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '⣿';
            this.txtPwd.Size = new System.Drawing.Size(100, 24);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(81, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "类  型：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学  生",
            "教  师",
            "管理员"});
            this.comboBox1.Location = new System.Drawing.Point(167, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文隶书", 18.15126F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "高校成绩管理系统";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // 登陆界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;//设置背景
            this.ClientSize = new System.Drawing.Size(384, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.退出);
            this.Controls.Add(this.登录);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.用户名);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "登陆界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.登陆界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 用户名;
        private System.Windows.Forms.Label 密码;
        private System.Windows.Forms.Button 登录;
        private System.Windows.Forms.Button 退出;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}