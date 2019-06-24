namespace BookManager.module.Manager.BookManage
{
    partial class EditBookInfo
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
            this.BookNumMes = new System.Windows.Forms.Label();
            this.BookWriterMes = new System.Windows.Forms.Label();
            this.BookNameMes = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.editBookType = new System.Windows.Forms.ComboBox();
            this.editBookDate = new System.Windows.Forms.DateTimePicker();
            this.editBookRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editBookNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editBookPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editBookPublish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editBookWriter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookNumMes
            // 
            this.BookNumMes.AutoSize = true;
            this.BookNumMes.ForeColor = System.Drawing.Color.Red;
            this.BookNumMes.Location = new System.Drawing.Point(282, 163);
            this.BookNumMes.Name = "BookNumMes";
            this.BookNumMes.Size = new System.Drawing.Size(101, 12);
            this.BookNumMes.TabIndex = 29;
            this.BookNumMes.Text = "书籍数量不能为空";
            this.BookNumMes.Visible = false;
            // 
            // BookWriterMes
            // 
            this.BookWriterMes.AutoSize = true;
            this.BookWriterMes.BackColor = System.Drawing.SystemColors.Control;
            this.BookWriterMes.ForeColor = System.Drawing.Color.Red;
            this.BookWriterMes.Location = new System.Drawing.Point(282, 55);
            this.BookWriterMes.Name = "BookWriterMes";
            this.BookWriterMes.Size = new System.Drawing.Size(101, 12);
            this.BookWriterMes.TabIndex = 28;
            this.BookWriterMes.Text = "作者姓名不能为空";
            this.BookWriterMes.Visible = false;
            // 
            // BookNameMes
            // 
            this.BookNameMes.AutoSize = true;
            this.BookNameMes.BackColor = System.Drawing.SystemColors.Control;
            this.BookNameMes.ForeColor = System.Drawing.Color.Red;
            this.BookNameMes.Location = new System.Drawing.Point(282, 28);
            this.BookNameMes.Name = "BookNameMes";
            this.BookNameMes.Size = new System.Drawing.Size(101, 12);
            this.BookNameMes.TabIndex = 27;
            this.BookNameMes.Text = "书籍名称不能为空";
            this.BookNameMes.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(291, 344);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "添加";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // editBookType
            // 
            this.editBookType.FormattingEnabled = true;
            this.editBookType.Location = new System.Drawing.Point(96, 188);
            this.editBookType.Name = "editBookType";
            this.editBookType.Size = new System.Drawing.Size(180, 20);
            this.editBookType.TabIndex = 24;
            // 
            // editBookDate
            // 
            this.editBookDate.Location = new System.Drawing.Point(96, 106);
            this.editBookDate.Name = "editBookDate";
            this.editBookDate.Size = new System.Drawing.Size(180, 21);
            this.editBookDate.TabIndex = 23;
            // 
            // editBookRemark
            // 
            this.editBookRemark.Location = new System.Drawing.Point(96, 214);
            this.editBookRemark.Multiline = true;
            this.editBookRemark.Name = "editBookRemark";
            this.editBookRemark.Size = new System.Drawing.Size(180, 92);
            this.editBookRemark.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "书籍类型";
            // 
            // editBookNum
            // 
            this.editBookNum.Location = new System.Drawing.Point(96, 160);
            this.editBookNum.Name = "editBookNum";
            this.editBookNum.Size = new System.Drawing.Size(180, 21);
            this.editBookNum.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "数量";
            // 
            // editBookPrice
            // 
            this.editBookPrice.Location = new System.Drawing.Point(96, 133);
            this.editBookPrice.Name = "editBookPrice";
            this.editBookPrice.Size = new System.Drawing.Size(180, 21);
            this.editBookPrice.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "出版时间";
            // 
            // editBookPublish
            // 
            this.editBookPublish.Location = new System.Drawing.Point(96, 79);
            this.editBookPublish.Name = "editBookPublish";
            this.editBookPublish.Size = new System.Drawing.Size(180, 21);
            this.editBookPublish.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "出版社";
            // 
            // editBookWriter
            // 
            this.editBookWriter.Location = new System.Drawing.Point(96, 52);
            this.editBookWriter.Name = "editBookWriter";
            this.editBookWriter.Size = new System.Drawing.Size(180, 21);
            this.editBookWriter.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "作者";
            // 
            // editBookName
            // 
            this.editBookName.Location = new System.Drawing.Point(96, 25);
            this.editBookName.Name = "editBookName";
            this.editBookName.Size = new System.Drawing.Size(180, 21);
            this.editBookName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "书籍名称";
            // 
            // EditBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 393);
            this.Controls.Add(this.BookNumMes);
            this.Controls.Add(this.BookWriterMes);
            this.Controls.Add(this.BookNameMes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.editBookType);
            this.Controls.Add(this.editBookDate);
            this.Controls.Add(this.editBookRemark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editBookNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editBookPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editBookPublish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editBookWriter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editBookName);
            this.Controls.Add(this.label1);
            this.Name = "EditBookInfo";
            this.Text = "EditBookInfo";
            this.Load += new System.EventHandler(this.EditBookInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNumMes;
        private System.Windows.Forms.Label BookWriterMes;
        private System.Windows.Forms.Label BookNameMes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox editBookType;
        private System.Windows.Forms.DateTimePicker editBookDate;
        private System.Windows.Forms.TextBox editBookRemark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editBookNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editBookPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editBookPublish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editBookWriter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editBookName;
        private System.Windows.Forms.Label label1;
    }
}