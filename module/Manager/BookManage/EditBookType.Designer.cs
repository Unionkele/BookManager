namespace BookManager.module.Manager.BookManage
{
    partial class EditBookType
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
            this.lbTypeInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbBookRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTypeInfo
            // 
            this.lbTypeInfo.AutoSize = true;
            this.lbTypeInfo.Location = new System.Drawing.Point(70, 58);
            this.lbTypeInfo.Name = "lbTypeInfo";
            this.lbTypeInfo.Size = new System.Drawing.Size(0, 12);
            this.lbTypeInfo.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(108, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tbBookRemark
            // 
            this.tbBookRemark.Location = new System.Drawing.Point(68, 80);
            this.tbBookRemark.Multiline = true;
            this.tbBookRemark.Name = "tbBookRemark";
            this.tbBookRemark.Size = new System.Drawing.Size(174, 96);
            this.tbBookRemark.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "备注";
            // 
            // tbBookType
            // 
            this.tbBookType.Location = new System.Drawing.Point(68, 27);
            this.tbBookType.Name = "tbBookType";
            this.tbBookType.Size = new System.Drawing.Size(174, 21);
            this.tbBookType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "类别";
            // 
            // btnUpdata
            // 
            this.btnUpdata.Location = new System.Drawing.Point(189, 213);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(75, 23);
            this.btnUpdata.TabIndex = 5;
            this.btnUpdata.Text = "保存信息";
            this.btnUpdata.UseVisualStyleBackColor = true;
            this.btnUpdata.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // EditBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbTypeInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbBookRemark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBookType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdata);
            this.Name = "EditBookType";
            this.Text = "类型编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTypeInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbBookRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdata;
    }
}