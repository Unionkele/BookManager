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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户类型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIdentity = new System.Windows.Forms.ComboBox();
            this.InfoSearch = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.余额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PersonCode,
            this.用户名,
            this.性别,
            this.电话,
            this.账号,
            this.余额,
            this.类别,
            this.备注});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 303);
            this.dataGridView1.TabIndex = 1;
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(429, 33);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(132, 21);
            this.searchKey.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.用户类型管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 用户类型管理ToolStripMenuItem
            // 
            this.用户类型管理ToolStripMenuItem.Name = "用户类型管理ToolStripMenuItem";
            this.用户类型管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.用户类型管理ToolStripMenuItem.Text = "用户类型管理";
            this.用户类型管理ToolStripMenuItem.Click += new System.EventHandler(this.用户类型管理ToolStripMenuItem_Click);
            // 
            // cbIdentity
            // 
            this.cbIdentity.FormattingEnabled = true;
            this.cbIdentity.Location = new System.Drawing.Point(302, 33);
            this.cbIdentity.Name = "cbIdentity";
            this.cbIdentity.Size = new System.Drawing.Size(121, 20);
            this.cbIdentity.TabIndex = 5;
            // 
            // InfoSearch
            // 
            this.InfoSearch.Location = new System.Drawing.Point(604, 31);
            this.InfoSearch.Name = "InfoSearch";
            this.InfoSearch.Size = new System.Drawing.Size(75, 23);
            this.InfoSearch.TabIndex = 6;
            this.InfoSearch.Text = "查询";
            this.InfoSearch.UseVisualStyleBackColor = true;
            this.InfoSearch.Click += new System.EventHandler(this.InfoSearch_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // PersonCode
            // 
            this.PersonCode.DataPropertyName = "PersonCode";
            this.PersonCode.HeaderText = "密码";
            this.PersonCode.Name = "PersonCode";
            this.PersonCode.Visible = false;
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
            // DisplayPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.InfoSearch);
            this.Controls.Add(this.cbIdentity);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DisplayPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息管理";
            this.Load += new System.EventHandler(this.DisplayPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIdentity;
        private System.Windows.Forms.Button InfoSearch;
        private System.Windows.Forms.ToolStripMenuItem 用户类型管理ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 余额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}