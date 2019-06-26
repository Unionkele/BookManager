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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.余额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.用户名,
            this.性别,
            this.电话,
            this.账号,
            this.密码,
            this.余额,
            this.类别,
            this.备注});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(845, 319);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // 用户名
            // 
            this.用户名.DataPropertyName = "PersonName";
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "PersonSex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            // 
            // 电话
            // 
            this.电话.DataPropertyName = "PersonPhone";
            this.电话.HeaderText = "电话";
            this.电话.Name = "电话";
            // 
            // 账号
            // 
            this.账号.DataPropertyName = "PersonNum";
            this.账号.HeaderText = "账号";
            this.账号.Name = "账号";
            // 
            // 密码
            // 
            this.密码.DataPropertyName = "PersonCode";
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            // 
            // 余额
            // 
            this.余额.DataPropertyName = "PersonMoney";
            this.余额.HeaderText = "余额";
            this.余额.Name = "余额";
            // 
            // 类别
            // 
            this.类别.DataPropertyName = "PersonIdentity";
            this.类别.HeaderText = "类别";
            this.类别.Name = "类别";
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "PersonRemark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 3;
            // 
            // DisplayPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 363);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "DisplayPerson";
            this.Text = "DisplayPerson";
            this.Load += new System.EventHandler(this.DisplayPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 余额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}