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
using BookManager.model;

namespace BookManager.module.Manager.BookManage
{
    public partial class AddBookType : Form
    {
        private DisplayBookType displayType;
        public AddBookType()
        {
            InitializeComponent();
        }
        public AddBookType(DisplayBookType displayType)
        {
            this.displayType = displayType;
        }
        private void AddType()
        {
            if (tbBookType.Text != "")
            {
                BookType typeInfo = new BookType();
                typeInfo.BType = tbBookType.Text;
                bool sel = typeInfo.Find();
                if (sel)
                {
                    lbTypeInfo.Text = "该类别已存在";
                    tbBookType.Clear();
                }
                else
                {
                    lbTypeInfo.Visible = false;
                    typeInfo.BType = tbBookType.Text;
                    typeInfo.BRemark = tbBookRemark.Text;
                    int res = typeInfo.Save();
                    if (res == 0)
                    {
                        MessageBox.Show("添加失败", "提示信息");
                    }
                    else
                    {
                        displayType.showTypeInfo();
                        MessageBox.Show("添加成功", "提示信息");
                    }
                }
            }
            else
            {
                lbTypeInfo.Text = "请输入类别";
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {

            AddType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
