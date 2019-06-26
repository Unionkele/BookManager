namespace BookManager.module.Manager.PersonManage
{
    partial class AddPersonInfo
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
            this.tbPersonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPersonPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPersonNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPersonMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersonRemark = new System.Windows.Forms.TextBox();
            this.cbPersonSex = new System.Windows.Forms.ComboBox();
            this.subPersonInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbPersonIdentity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // tbPersonName
            // 
            this.tbPersonName.Location = new System.Drawing.Point(137, 29);
            this.tbPersonName.Name = "tbPersonName";
            this.tbPersonName.Size = new System.Drawing.Size(188, 21);
            this.tbPersonName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "电话";
            // 
            // tbPersonPhone
            // 
            this.tbPersonPhone.Location = new System.Drawing.Point(137, 118);
            this.tbPersonPhone.Name = "tbPersonPhone";
            this.tbPersonPhone.Size = new System.Drawing.Size(188, 21);
            this.tbPersonPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "账号";
            // 
            // tbPersonNum
            // 
            this.tbPersonNum.Location = new System.Drawing.Point(137, 159);
            this.tbPersonNum.Name = "tbPersonNum";
            this.tbPersonNum.Size = new System.Drawing.Size(188, 21);
            this.tbPersonNum.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "余额";
            // 
            // tbPersonMoney
            // 
            this.tbPersonMoney.Location = new System.Drawing.Point(137, 197);
            this.tbPersonMoney.Name = "tbPersonMoney";
            this.tbPersonMoney.Size = new System.Drawing.Size(188, 21);
            this.tbPersonMoney.TabIndex = 1;
            this.tbPersonMoney.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "类别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "备注";
            // 
            // tbPersonRemark
            // 
            this.tbPersonRemark.Location = new System.Drawing.Point(137, 277);
            this.tbPersonRemark.Multiline = true;
            this.tbPersonRemark.Name = "tbPersonRemark";
            this.tbPersonRemark.Size = new System.Drawing.Size(188, 71);
            this.tbPersonRemark.TabIndex = 1;
            // 
            // cbPersonSex
            // 
            this.cbPersonSex.AutoCompleteCustomSource.AddRange(new string[] {
            "男",
            "女"});
            this.cbPersonSex.FormattingEnabled = true;
            this.cbPersonSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbPersonSex.Location = new System.Drawing.Point(137, 74);
            this.cbPersonSex.Name = "cbPersonSex";
            this.cbPersonSex.Size = new System.Drawing.Size(188, 20);
            this.cbPersonSex.TabIndex = 2;
            // 
            // subPersonInfo
            // 
            this.subPersonInfo.Location = new System.Drawing.Point(228, 386);
            this.subPersonInfo.Name = "subPersonInfo";
            this.subPersonInfo.Size = new System.Drawing.Size(75, 23);
            this.subPersonInfo.TabIndex = 3;
            this.subPersonInfo.Text = "添加";
            this.subPersonInfo.UseVisualStyleBackColor = true;
            this.subPersonInfo.Click += new System.EventHandler(this.subPersonInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbPersonIdentity
            // 
            this.cbPersonIdentity.FormattingEnabled = true;
            this.cbPersonIdentity.Location = new System.Drawing.Point(137, 238);
            this.cbPersonIdentity.Name = "cbPersonIdentity";
            this.cbPersonIdentity.Size = new System.Drawing.Size(188, 20);
            this.cbPersonIdentity.TabIndex = 5;
            // 
            // AddPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 421);
            this.Controls.Add(this.cbPersonIdentity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.subPersonInfo);
            this.Controls.Add(this.cbPersonSex);
            this.Controls.Add(this.tbPersonRemark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPersonMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPersonNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPersonPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPersonName);
            this.Controls.Add(this.label1);
            this.Name = "AddPersonInfo";
            this.Text = "用户添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPersonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPersonPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPersonNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPersonMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPersonRemark;
        private System.Windows.Forms.ComboBox cbPersonSex;
        private System.Windows.Forms.Button subPersonInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbPersonIdentity;
    }
}