namespace BookManager.module.Login
{
    partial class RegisterForm
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
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegPwd = new System.Windows.Forms.TextBox();
            this.SubReg = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // tbRegName
            // 
            this.tbRegName.Location = new System.Drawing.Point(116, 68);
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.Size = new System.Drawing.Size(100, 21);
            this.tbRegName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // tbRegPwd
            // 
            this.tbRegPwd.Location = new System.Drawing.Point(116, 114);
            this.tbRegPwd.Name = "tbRegPwd";
            this.tbRegPwd.PasswordChar = '*';
            this.tbRegPwd.Size = new System.Drawing.Size(100, 21);
            this.tbRegPwd.TabIndex = 1;
            // 
            // SubReg
            // 
            this.SubReg.Location = new System.Drawing.Point(60, 169);
            this.SubReg.Name = "SubReg";
            this.SubReg.Size = new System.Drawing.Size(75, 23);
            this.SubReg.TabIndex = 2;
            this.SubReg.Text = "注册";
            this.SubReg.UseVisualStyleBackColor = true;
            this.SubReg.Click += new System.EventHandler(this.SubReg_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "图书信息系统";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(117, 96);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(77, 12);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "请输入用户名";
            this.lbName.Visible = false;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.BackColor = System.Drawing.SystemColors.Control;
            this.lbPwd.ForeColor = System.Drawing.Color.Red;
            this.lbPwd.Location = new System.Drawing.Point(117, 138);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(65, 12);
            this.lbPwd.TabIndex = 6;
            this.lbPwd.Text = "请输入密码";
            this.lbPwd.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.lbPwd);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SubReg);
            this.Controls.Add(this.tbRegPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegName);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegPwd;
        private System.Windows.Forms.Button SubReg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPwd;
    }
}