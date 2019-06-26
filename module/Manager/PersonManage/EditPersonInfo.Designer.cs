namespace BookManager.module.Manager.PersonManage
{
    partial class EditPersonInfo
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
            this.setPersonIdentity = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.editPerson = new System.Windows.Forms.Button();
            this.setPersonSex = new System.Windows.Forms.ComboBox();
            this.setPersonRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.setPersonMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.setPersonNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setPersonPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setPersonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setPersonIdentity
            // 
            this.setPersonIdentity.FormattingEnabled = true;
            this.setPersonIdentity.Location = new System.Drawing.Point(80, 228);
            this.setPersonIdentity.Name = "setPersonIdentity";
            this.setPersonIdentity.Size = new System.Drawing.Size(188, 20);
            this.setPersonIdentity.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(265, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // editPerson
            // 
            this.editPerson.Location = new System.Drawing.Point(171, 376);
            this.editPerson.Name = "editPerson";
            this.editPerson.Size = new System.Drawing.Size(75, 23);
            this.editPerson.TabIndex = 19;
            this.editPerson.Text = "保存信息";
            this.editPerson.UseVisualStyleBackColor = true;
            this.editPerson.Click += new System.EventHandler(this.editPerson_Click);
            // 
            // setPersonSex
            // 
            this.setPersonSex.AutoCompleteCustomSource.AddRange(new string[] {
            "男",
            "女"});
            this.setPersonSex.FormattingEnabled = true;
            this.setPersonSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.setPersonSex.Location = new System.Drawing.Point(80, 64);
            this.setPersonSex.Name = "setPersonSex";
            this.setPersonSex.Size = new System.Drawing.Size(188, 20);
            this.setPersonSex.TabIndex = 18;
            // 
            // setPersonRemark
            // 
            this.setPersonRemark.Location = new System.Drawing.Point(80, 267);
            this.setPersonRemark.Multiline = true;
            this.setPersonRemark.Name = "setPersonRemark";
            this.setPersonRemark.Size = new System.Drawing.Size(188, 71);
            this.setPersonRemark.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "备注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "类别";
            // 
            // setPersonMoney
            // 
            this.setPersonMoney.Location = new System.Drawing.Point(80, 187);
            this.setPersonMoney.Name = "setPersonMoney";
            this.setPersonMoney.Size = new System.Drawing.Size(188, 21);
            this.setPersonMoney.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "余额";
            // 
            // setPersonNum
            // 
            this.setPersonNum.Location = new System.Drawing.Point(80, 149);
            this.setPersonNum.Name = "setPersonNum";
            this.setPersonNum.Size = new System.Drawing.Size(188, 21);
            this.setPersonNum.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "账号";
            // 
            // setPersonPhone
            // 
            this.setPersonPhone.Location = new System.Drawing.Point(80, 108);
            this.setPersonPhone.Name = "setPersonPhone";
            this.setPersonPhone.Size = new System.Drawing.Size(188, 21);
            this.setPersonPhone.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "性别";
            // 
            // setPersonName
            // 
            this.setPersonName.Location = new System.Drawing.Point(80, 19);
            this.setPersonName.Name = "setPersonName";
            this.setPersonName.Size = new System.Drawing.Size(188, 21);
            this.setPersonName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "姓名";
            // 
            // EditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 418);
            this.Controls.Add(this.setPersonIdentity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.editPerson);
            this.Controls.Add(this.setPersonSex);
            this.Controls.Add(this.setPersonRemark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.setPersonMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.setPersonNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setPersonPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setPersonName);
            this.Controls.Add(this.label1);
            this.Name = "EditPersonInfo";
            this.Text = "设置用户信息";
            this.Load += new System.EventHandler(this.EditPersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox setPersonIdentity;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button editPerson;
        private System.Windows.Forms.ComboBox setPersonSex;
        private System.Windows.Forms.TextBox setPersonRemark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox setPersonMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox setPersonNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setPersonPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setPersonName;
        private System.Windows.Forms.Label label1;
    }
}