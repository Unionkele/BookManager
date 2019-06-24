using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NetDB.Core;
using NetDB.Core.Support;
using BookManager.model;

namespace BookManager.module.Manager.BookManage
{
    public partial class AddBookInfo : Form
    {
        private DisplayBook displayBook;

        public AddBookInfo(DisplayBook displayBook)
        {
            InitializeComponent();
            this.displayBook = displayBook;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addInfo();
          
        }
        //信息添加
        private void addInfo()
        {
            if (tbBookName.Text != "" && tbBookWriter.Text != "" && tbBookNum.Text != "")
            {
                BookInfo Binfo = new BookInfo();
                Binfo.BookName = tbBookName.Text;
                Binfo.BookWriter = tbBookWriter.Text;
                Binfo.BookPublish = tbBookPublish.Text;
                Binfo.BookDate = dtBookDate.Value;
                Binfo.BookPrice = Convert.ToSingle(tbBookPrice.Text);
                Binfo.BookType = cmBookType.Text;
                Binfo.BookNum = Convert.ToInt32(tbBookNum.Text);
                Binfo.BookRemark = tbBookRemark.Text;

                int res = Binfo.Save();
                if (res == 0)
                {
                    MessageBox.Show("添加失败", "提示信息");                   
                }
                else
                {
                    displayBook.showBookInfo();
                    MessageBox.Show("添加成功", "提示信息");                    
                }
            }
            else
            {
                if (tbBookName.Text == "")
                {
                    BookNameMes.Visible = true;
                }
                else
                {
                    BookNameMes.Visible = false;
                }
                if (tbBookWriter.Text == "")
                {
                    BookWriterMes.Visible = true;
                }
                else
                {
                    BookWriterMes.Visible = false;
                }
                if (tbBookNum.Text == "")
                {
                    BookNumMes.Visible = true;
                }
                else
                {
                    BookNumMes.Visible = false;
                }
            }
        }
        //清除输入框
        private void clearBox()
        {
            tbBookName.Text="";
            tbBookWriter.Text="";
            tbBookPublish.Text="";
            tbBookPrice.Text="0";
            tbBookNum.Text="";
            tbBookRemark.Text="";
        }
        
    }
}
