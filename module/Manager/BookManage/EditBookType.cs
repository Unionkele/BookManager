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
    public partial class EditBookType : Form
    {
        private string EditID;
        private DisplayBookType displayType;
        public EditBookType()
        {
            InitializeComponent();
        }
        public EditBookType(string ID, DisplayBookType displayType)
        {
            this.EditID = ID;
            this.displayType = displayType;
        }
        private void editList()
        {
            BookType editType = new BookType();
            editType.ID = EditID;
            tbBookType.Text = editType.BType;
            tbBookRemark.Text = editType.BRemark;
        }

        private void subEdit()
        {
            if (tbBookType.Text != "")
            {
                lbTypeInfo.Visible = false;
                BookType typeInfo = new BookType();
                typeInfo.BType = tbBookType.Text;
                typeInfo.BRemark = tbBookRemark.Text;
                typeInfo.ID = EditID;
                int res = typeInfo.Update();
                if (res == 0)
                {
                    MessageBox.Show("更新失败", "提示信息");
                }
                else
                {
                    displayType.showTypeInfo();
                    MessageBox.Show("更新成功", "提示信息");
                }
            }
            else
            {
                lbTypeInfo.Text = "类型名称不能为空";
            }

        }
        private void btnUpdata_Click(object sender, EventArgs e)
        {
            subEdit();
        }
    }
}
