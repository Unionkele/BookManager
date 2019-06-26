namespace BookManager.module.Login
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoginer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLoginPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subLogin = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书信息系统";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoginer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLoginPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLoginName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbLoginer
            // 
            this.cbLoginer.FormattingEnabled = true;
            this.cbLoginer.Items.AddRange(new object[] {
            "普通用户",
            "管理者"});
            this.cbLoginer.Location = new System.Drawing.Point(110, 103);
            this.cbLoginer.Name = "cbLoginer";
            this.cbLoginer.Size = new System.Drawing.Size(121, 20);
            this.cbLoginer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "登录者";
            // 
            // tbLoginPwd
            // 
            this.tbLoginPwd.Location = new System.Drawing.Point(110, 69);
            this.tbLoginPwd.Name = "tbLoginPwd";
            this.tbLoginPwd.PasswordChar = '*';
            this.tbLoginPwd.Size = new System.Drawing.Size(121, 21);
            this.tbLoginPwd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码";
            // 
            // tbLoginName
            // 
            this.tbLoginName.Location = new System.Drawing.Point(110, 32);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(121, 21);
            this.tbLoginName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名";
            // 
            // subLogin
            // 
            this.subLogin.Location = new System.Drawing.Point(63, 211);
            this.subLogin.Name = "subLogin";
            this.subLogin.Size = new System.Drawing.Size(75, 23);
            this.subLogin.TabIndex = 2;
            this.subLogin.Text = "登录";
            this.subLogin.UseVisualStyleBackColor = true;
            this.subLogin.Click += new System.EventHandler(this.subLogin_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(177, 211);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(75, 23);
            this.res.TabIndex = 3;
            this.res.Text = "注册";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 258);
            this.Controls.Add(this.res);
            this.Controls.Add(this.subLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "登录界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoginer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLoginPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button subLogin;
        private System.Windows.Forms.Button res;
    }
}