namespace 高校成绩管理系统
{
    partial class 学生成绩查询
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.确定 = new System.Windows.Forms.Button();
            this.t学分 = new System.Windows.Forms.TextBox();
            this.已修学分 = new System.Windows.Forms.Label();
            this.t学号 = new System.Windows.Forms.TextBox();
            this.学号 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(717, 201);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(565, 34);
            this.确定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(100, 26);
            this.确定.TabIndex = 0;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.退出_Click);
            // 
            // t学分
            // 
            this.t学分.Location = new System.Drawing.Point(417, 35);
            this.t学分.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t学分.Name = "t学分";
            this.t学分.Size = new System.Drawing.Size(91, 25);
            this.t学分.TabIndex = 4;
            // 
            // 已修学分
            // 
            this.已修学分.AutoSize = true;
            this.已修学分.BackColor = System.Drawing.Color.Transparent;
            this.已修学分.Font = new System.Drawing.Font("宋体", 12F);
            this.已修学分.Location = new System.Drawing.Point(303, 41);
            this.已修学分.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.已修学分.Name = "已修学分";
            this.已修学分.Size = new System.Drawing.Size(99, 20);
            this.已修学分.TabIndex = 3;
            this.已修学分.Text = "已修学分:";
            // 
            // t学号
            // 
            this.t学号.Location = new System.Drawing.Point(109, 35);
            this.t学号.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t学号.Name = "t学号";
            this.t学号.Size = new System.Drawing.Size(112, 25);
            this.t学号.TabIndex = 2;
            // 
            // 学号
            // 
            this.学号.AutoSize = true;
            this.学号.BackColor = System.Drawing.Color.Transparent;
            this.学号.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学号.Location = new System.Drawing.Point(37, 41);
            this.学号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(59, 20);
            this.学号.TabIndex = 1;
            this.学号.Text = "学号:";
            // 
            // 学生成绩查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(752, 312);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.t学分);
            this.Controls.Add(this.已修学分);
            this.Controls.Add(this.t学号);
            this.Controls.Add(this.学号);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "学生成绩查询";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩查询";
            this.Load += new System.EventHandler(this.学生成绩查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.TextBox t学分;
        private System.Windows.Forms.Label 已修学分;
        private System.Windows.Forms.TextBox t学号;
        private System.Windows.Forms.Label 学号;
    }
}