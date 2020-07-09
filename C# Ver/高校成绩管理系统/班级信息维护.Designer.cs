namespace 高校成绩管理系统
{
    partial class 班级信息维护
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.Cannel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.Gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.Location = new System.Drawing.Point(27, 222);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 29);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Cannel
            // 
            this.Cannel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cannel.Location = new System.Drawing.Point(243, 222);
            this.Cannel.Margin = new System.Windows.Forms.Padding(4);
            this.Cannel.Name = "Cannel";
            this.Cannel.Size = new System.Drawing.Size(100, 29);
            this.Cannel.TabIndex = 12;
            this.Cannel.Text = "返回";
            this.Cannel.UseVisualStyleBackColor = true;
            this.Cannel.Click += new System.EventHandler(this.Cannel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(135, 222);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGView
            // 
            this.dataGView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(389, 15);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(520, 269);
            this.dataGView.TabIndex = 8;
            this.dataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGView_CellContentClick);
            // 
            // Gbox
            // 
            this.Gbox.BackColor = System.Drawing.Color.Transparent;
            this.Gbox.Controls.Add(this.comboBox1);
            this.Gbox.Controls.Add(this.textBox2);
            this.Gbox.Controls.Add(this.textBox1);
            this.Gbox.Controls.Add(this.label2);
            this.Gbox.Controls.Add(this.label1);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Location = new System.Drawing.Point(68, 15);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox.Size = new System.Drawing.Size(287, 176);
            this.Gbox.TabIndex = 7;
            this.Gbox.TabStop = false;
            this.Gbox.Enter += new System.EventHandler(this.Gbox_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(101, 130);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "专业编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "班级名称";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laSno.Location = new System.Drawing.Point(8, 40);
            this.laSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(67, 15);
            this.laSno.TabIndex = 3;
            this.laSno.Text = "班级编号";
            this.laSno.Click += new System.EventHandler(this.laSno_Click);
            // 
            // 班级信息维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(935, 313);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Cannel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "班级信息维护";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级信息维护";
            this.Load += new System.EventHandler(this.班级信息维护_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button Cannel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox comboBox1;
    }
}