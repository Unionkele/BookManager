namespace BookManager.module.Manager.PersonManager
{
    partial class DisplayPerson
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.用户姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.余额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加用户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改用户信息";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除用户";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户姓名,
            this.用户性别,
            this.用户电话,
            this.用户账号,
            this.用户密码,
            this.余额,
            this.用户类型,
            this.备注});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 354);
            this.dataGridView1.TabIndex = 4;
            // 
            // 用户姓名
            // 
            this.用户姓名.HeaderText = "用户姓名";
            this.用户姓名.Name = "用户姓名";
            // 
            // 用户性别
            // 
            this.用户性别.HeaderText = "用户性别";
            this.用户性别.Name = "用户性别";
            // 
            // 用户电话
            // 
            this.用户电话.HeaderText = "用户电话";
            this.用户电话.Name = "用户电话";
            // 
            // 用户账号
            // 
            this.用户账号.HeaderText = "用户账号";
            this.用户账号.Name = "用户账号";
            // 
            // 用户密码
            // 
            this.用户密码.HeaderText = "用户密码";
            this.用户密码.Name = "用户密码";
            // 
            // 余额
            // 
            this.余额.HeaderText = "余额";
            this.余额.Name = "余额";
            // 
            // 用户类型
            // 
            this.用户类型.HeaderText = "用户类型";
            this.用户类型.Name = "用户类型";
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // DisplayPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 418);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DisplayPerson";
            this.Text = "DisplayPerson";
            this.Load += new System.EventHandler(this.DisplayPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 余额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}