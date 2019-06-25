namespace BookManager.module.Manager.BookManage
{
    partial class AddBookType
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
            this.btnType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBookType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookRemark = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTypeInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(197, 227);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 23);
            this.btnType.TabIndex = 0;
            this.btnType.Text = "添加";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类别";
            // 
            // tbBookType
            // 
            this.tbBookType.Location = new System.Drawing.Point(76, 41);
            this.tbBookType.Name = "tbBookType";
            this.tbBookType.Size = new System.Drawing.Size(174, 21);
            this.tbBookType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "备注";
            // 
            // tbBookRemark
            // 
            this.tbBookRemark.Location = new System.Drawing.Point(76, 94);
            this.tbBookRemark.Multiline = true;
            this.tbBookRemark.Name = "tbBookRemark";
            this.tbBookRemark.Size = new System.Drawing.Size(174, 96);
            this.tbBookRemark.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(116, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTypeInfo
            // 
            this.lbTypeInfo.AutoSize = true;
            this.lbTypeInfo.ForeColor = System.Drawing.Color.Red;
            this.lbTypeInfo.Location = new System.Drawing.Point(78, 72);
            this.lbTypeInfo.Name = "lbTypeInfo";
            this.lbTypeInfo.Size = new System.Drawing.Size(0, 12);
            this.lbTypeInfo.TabIndex = 4;
            // 
            // AddBookType
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
            this.Controls.Add(this.btnType);
            this.Name = "AddBookType";
            this.Text = "类型添加";
            this.Load += new System.EventHandler(this.AddBookType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBookType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookRemark;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTypeInfo;
    }
}