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
    public partial class EditBookInfo : Form
    {
        public string EditID;
        public EditBookInfo()
        {
            InitializeComponent();
        }
        //初始数据获取
        private void showEditInfo()
        {
            BookInfo editInfo = new BookInfo();
            editInfo.ID = EditID;
            editInfo.Find();
            editBookName.Text = editInfo.BookName;
            editBookWriter.Text = editInfo.BookWriter;
            editBookPublish.Text = editInfo.BookPublish;
            editBookDate.Value = editInfo.BookDate;
            editBookPrice.Text =  Convert.ToString(editInfo.BookPrice);
            editBookNum.Text = Convert.ToString(editInfo.BookNum);
            editBookType.Text = editInfo.BookType;
            editBookRemark.Text = editInfo.BookRemark;
        }
        //更新信息
        private void updataInfo()
        {
            if (editBookName.Text != "" && editBookWriter.Text != "" && editBookNum.Text != "")
            {
                BookInfo Einfo = new BookInfo();
                Einfo.BookName = editBookName.Text;
                Einfo.BookWriter = editBookWriter.Text;
                Einfo.BookPublish = editBookPublish.Text;
                Einfo.BookDate = editBookDate.Value;
                Einfo.BookPrice = Convert.ToSingle(editBookPrice.Text);
                Einfo.BookType = editBookType.Text;
                Einfo.BookNum = Convert.ToInt32(editBookNum.Text);
                Einfo.BookRemark = editBookRemark.Text;
                Einfo.ID = EditID;
                int res = Einfo.Update();
                if (res == 0)
                {
                    MessageBox.Show("更新失败", "提示信息");
                }
                else
                {
                    DisplayBook display = (DisplayBook)this.Owner;
                    display.showBookInfo();
                    MessageBox.Show("更新成功", "提示信息");                
                }
            }
            else
            {
                if (editBookName.Text == "")
                {
                    BookNameMes.Visible = true;
                }
                else
                {
                    BookNameMes.Visible = false;
                }
                if (editBookWriter.Text == "")
                {
                    BookWriterMes.Visible = true;
                }
                else
                {
                    BookWriterMes.Visible = false;
                }
                if (editBookNum.Text == "")
                {
                    BookNumMes.Visible = true;
                }
                else
                {
                    BookNumMes.Visible = false;
                }
            }
        }
        //加载下拉框列表
        private void TypeList()
        {
            PageList<BookType> typelist = ORMSupport.PageSelect<BookType>()
                .Select();
            foreach (BookType item in typelist.Rows)
            {
                editBookType.Items.Add(item.BType);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBookInfo_Load(object sender, EventArgs e)
        {
            showEditInfo();
            TypeList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updataInfo();
        }

        private void editBookName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
