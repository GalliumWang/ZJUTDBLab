namespace 高校成绩管理系统
{
    partial class 专业信息维护
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
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Cannel = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.BackColor = System.Drawing.Color.Transparent;
            this.Gbox.Controls.Add(this.label1);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtDno);
            this.Gbox.Location = new System.Drawing.Point(33, 26);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox.Size = new System.Drawing.Size(509, 84);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "专业名称";
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(8, 40);
            this.laSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(67, 15);
            this.laSno.TabIndex = 3;
            this.laSno.Text = "专业编号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(347, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtDno
            // 
            this.txtDno.Location = new System.Drawing.Point(97, 36);
            this.txtDno.Margin = new System.Windows.Forms.Padding(4);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(132, 25);
            this.txtDno.TabIndex = 1;
            this.txtDno.TextChanged += new System.EventHandler(this.txtDno_TextChanged);
            // 
            // dataGView
            // 
            this.dataGView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(33, 118);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(509, 184);
            this.dataGView.TabIndex = 3;
            this.dataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(76, 330);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(229, 330);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Cannel
            // 
            this.Cannel.Location = new System.Drawing.Point(395, 330);
            this.Cannel.Margin = new System.Windows.Forms.Padding(4);
            this.Cannel.Name = "Cannel";
            this.Cannel.Size = new System.Drawing.Size(100, 29);
            this.Cannel.TabIndex = 6;
            this.Cannel.Text = "返回";
            this.Cannel.UseVisualStyleBackColor = true;
            this.Cannel.Click += new System.EventHandler(this.Cannel_Click);
            // 
            // 专业信息维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::高校成绩管理系统.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(580, 398);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Cannel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "专业信息维护";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专业信息维护";
            this.Load += new System.EventHandler(this.年级信息录入_Load);
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtDno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cannel;
    }
}