namespace BookManager.module.Manager.PersonManage
{
    partial class EditIdentityInfo
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
            this.lbBigNumMes = new System.Windows.Forms.Label();
            this.lbLongTimeMes = new System.Windows.Forms.Label();
            this.lbIdentityMes = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SubInfoBtn = new System.Windows.Forms.Button();
            this.EditBigNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditLongTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditIndentity = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBigNumMes
            // 
            this.lbBigNumMes.AutoSize = true;
            this.lbBigNumMes.ForeColor = System.Drawing.Color.Red;
            this.lbBigNumMes.Location = new System.Drawing.Point(228, 132);
            this.lbBigNumMes.Name = "lbBigNumMes";
            this.lbBigNumMes.Size = new System.Drawing.Size(53, 12);
            this.lbBigNumMes.TabIndex = 13;
            this.lbBigNumMes.Text = "不能为空";
            this.lbBigNumMes.Visible = false;
            // 
            // lbLongTimeMes
            // 
            this.lbLongTimeMes.AutoSize = true;
            this.lbLongTimeMes.ForeColor = System.Drawing.Color.Red;
            this.lbLongTimeMes.Location = new System.Drawing.Point(228, 81);
            this.lbLongTimeMes.Name = "lbLongTimeMes";
            this.lbLongTimeMes.Size = new System.Drawing.Size(53, 12);
            this.lbLongTimeMes.TabIndex = 14;
            this.lbLongTimeMes.Text = "不能为空";
            this.lbLongTimeMes.Visible = false;
            // 
            // lbIdentityMes
            // 
            this.lbIdentityMes.AutoSize = true;
            this.lbIdentityMes.ForeColor = System.Drawing.Color.Red;
            this.lbIdentityMes.Location = new System.Drawing.Point(228, 32);
            this.lbIdentityMes.Name = "lbIdentityMes";
            this.lbIdentityMes.Size = new System.Drawing.Size(53, 12);
            this.lbIdentityMes.TabIndex = 15;
            this.lbIdentityMes.Text = "不能为空";
            this.lbIdentityMes.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(192, 210);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // SubInfoBtn
            // 
            this.SubInfoBtn.Location = new System.Drawing.Point(95, 210);
            this.SubInfoBtn.Name = "SubInfoBtn";
            this.SubInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.SubInfoBtn.TabIndex = 11;
            this.SubInfoBtn.Text = "添加";
            this.SubInfoBtn.UseVisualStyleBackColor = true;
            this.SubInfoBtn.Click += new System.EventHandler(this.SubInfoBtn_Click);
            // 
            // EditBigNum
            // 
            this.EditBigNum.Location = new System.Drawing.Point(122, 129);
            this.EditBigNum.Name = "EditBigNum";
            this.EditBigNum.Size = new System.Drawing.Size(100, 21);
            this.EditBigNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "借书最大次数";
            // 
            // EditLongTime
            // 
            this.EditLongTime.Location = new System.Drawing.Point(122, 78);
            this.EditLongTime.Name = "EditLongTime";
            this.EditLongTime.Size = new System.Drawing.Size(100, 21);
            this.EditLongTime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "借书最大时长（天）";
            // 
            // EditIndentity
            // 
            this.EditIndentity.Location = new System.Drawing.Point(122, 29);
            this.EditIndentity.Name = "EditIndentity";
            this.EditIndentity.Size = new System.Drawing.Size(100, 21);
            this.EditIndentity.TabIndex = 10;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(63, 29);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(53, 12);
            this.lb.TabIndex = 7;
            this.lb.Text = "类型名称";
            // 
            // EditIdentityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 265);
            this.Controls.Add(this.lbBigNumMes);
            this.Controls.Add(this.lbLongTimeMes);
            this.Controls.Add(this.lbIdentityMes);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.SubInfoBtn);
            this.Controls.Add(this.EditBigNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditLongTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditIndentity);
            this.Controls.Add(this.lb);
            this.Name = "EditIdentityInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑用户类型";
            this.Load += new System.EventHandler(this.EditIdentityInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBigNumMes;
        private System.Windows.Forms.Label lbLongTimeMes;
        private System.Windows.Forms.Label lbIdentityMes;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button SubInfoBtn;
        private System.Windows.Forms.TextBox EditBigNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditLongTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditIndentity;
        private System.Windows.Forms.Label lb;
    }
}