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
        public AddBookInfo()
        {
            InitializeComponent();
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
            tbBookName.Focus();
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
                    DisplayBook display = (DisplayBook)this.Owner;
                    display.showBookInfo();
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
            tbBookName.Clear();
            tbBookWriter.Clear();
            tbBookPublish.Clear();
            tbBookPrice.Text = "0";
            tbBookNum.Clear();
            tbBookRemark.Clear();
        }
        private void TypeList()
        {
            PageList<BookType> typelist = ORMSupport.PageSelect<BookType>()
                .Select();
            foreach (BookType item in typelist.Rows)
            {
                cmBookType.Items.Add(item.BType);
            }
        }

        private void AddBookInfo_Load(object sender, EventArgs e)
        {
            TypeList();
            tbBookName.Focus();
        }

    }
}
