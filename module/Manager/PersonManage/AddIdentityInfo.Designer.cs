namespace BookManager.module.Manager.PersonManage
{
    partial class AddIdentityInfo
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
            this.lb = new System.Windows.Forms.Label();
            this.tbIndentity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLongTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBigNum = new System.Windows.Forms.TextBox();
            this.AddInfoBtn = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.lbIdentityMes = new System.Windows.Forms.Label();
            this.lbLongTimeMes = new System.Windows.Forms.Label();
            this.lbBigNumMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(71, 27);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(53, 12);
            this.lb.TabIndex = 0;
            this.lb.Text = "类型名称";
            // 
            // tbIndentity
            // 
            this.tbIndentity.Location = new System.Drawing.Point(130, 27);
            this.tbIndentity.Name = "tbIndentity";
            this.tbIndentity.Size = new System.Drawing.Size(100, 21);
            this.tbIndentity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "借书最大时长（天）";
            // 
            // tbLongTime
            // 
            this.tbLongTime.Location = new System.Drawing.Point(130, 76);
            this.tbLongTime.Name = "tbLongTime";
            this.tbLongTime.Size = new System.Drawing.Size(100, 21);
            this.tbLongTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "借书最大次数";
            // 
            // tbBigNum
            // 
            this.tbBigNum.Location = new System.Drawing.Point(130, 127);
            this.tbBigNum.Name = "tbBigNum";
            this.tbBigNum.Size = new System.Drawing.Size(100, 21);
            this.tbBigNum.TabIndex = 1;
            // 
            // AddInfoBtn
            // 
            this.AddInfoBtn.Location = new System.Drawing.Point(103, 208);
            this.AddInfoBtn.Name = "AddInfoBtn";
            this.AddInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.AddInfoBtn.TabIndex = 2;
            this.AddInfoBtn.Text = "添加";
            this.AddInfoBtn.UseVisualStyleBackColor = true;
            this.AddInfoBtn.Click += new System.EventHandler(this.AddInfoBtn_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(200, 208);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lbIdentityMes
            // 
            this.lbIdentityMes.AutoSize = true;
            this.lbIdentityMes.ForeColor = System.Drawing.Color.Red;
            this.lbIdentityMes.Location = new System.Drawing.Point(236, 30);
            this.lbIdentityMes.Name = "lbIdentityMes";
            this.lbIdentityMes.Size = new System.Drawing.Size(53, 12);
            this.lbIdentityMes.TabIndex = 4;
            this.lbIdentityMes.Text = "不能为空";
            this.lbIdentityMes.Visible = false;
            // 
            // lbLongTimeMes
            // 
            this.lbLongTimeMes.AutoSize = true;
            this.lbLongTimeMes.ForeColor = System.Drawing.Color.Red;
            this.lbLongTimeMes.Location = new System.Drawing.Point(236, 79);
            this.lbLongTimeMes.Name = "lbLongTimeMes";
            this.lbLongTimeMes.Size = new System.Drawing.Size(53, 12);
            this.lbLongTimeMes.TabIndex = 4;
            this.lbLongTimeMes.Text = "不能为空";
            this.lbLongTimeMes.Visible = false;
            // 
            // lbBigNumMes
            // 
            this.lbBigNumMes.AutoSize = true;
            this.lbBigNumMes.ForeColor = System.Drawing.Color.Red;
            this.lbBigNumMes.Location = new System.Drawing.Point(236, 130);
            this.lbBigNumMes.Name = "lbBigNumMes";
            this.lbBigNumMes.Size = new System.Drawing.Size(53, 12);
            this.lbBigNumMes.TabIndex = 4;
            this.lbBigNumMes.Text = "不能为空";
            this.lbBigNumMes.Visible = false;
            // 
            // AddIdentityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 256);
            this.Controls.Add(this.lbBigNumMes);
            this.Controls.Add(this.lbLongTimeMes);
            this.Controls.Add(this.lbIdentityMes);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.AddInfoBtn);
            this.Controls.Add(this.tbBigNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLongTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIndentity);
            this.Controls.Add(this.lb);
            this.Name = "AddIdentityInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增用户类型";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tbIndentity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLongTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBigNum;
        private System.Windows.Forms.Button AddInfoBtn;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label lbIdentityMes;
        private System.Windows.Forms.Label lbLongTimeMes;
        private System.Windows.Forms.Label lbBigNumMes;
    }
}