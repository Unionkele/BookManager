﻿using System;
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
        public AddBookType()
        {
            InitializeComponent();
        }
        private void AddType()
        {

        }

        private void btnType_Click(object sender, EventArgs e)
        {
            if (tbBookType.Text != "")
            {
                BookType typeInfo = new BookType();
                typeInfo.BType = tbBookType.Text;
                typeInfo.BRemark = tbBookRemark.Text;
                int res = typeInfo.Save();
                if (res == 0)
                {
                    MessageBox.Show("添加失败", "提示信息");
                }
                else
                {
                    MessageBox.Show("添加成功", "提示信息");
                }
            }
            else
            {
                lbTypeInfo.Text = "请输入类别";
            }

        }
    }
}
