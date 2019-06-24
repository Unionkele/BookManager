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
        private string EditID;
        public EditBookInfo(string ID)
        {
            InitializeComponent();
            this.EditID=ID;
        }
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

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBookInfo_Load(object sender, EventArgs e)
        {
            showEditInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updataInfo();
        }
    }
}
