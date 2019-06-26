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

namespace BookManager.module.book
{
    public partial class TcInfo : Form
    {
        public TcInfo()
        {
            InitializeComponent();
        }
        //书籍信息列表显示
        public void showBookInfo()
        {
            PageList<BookInfo> bookList = ORMSupport.PageSelect<BookInfo>()
                .Select();
            dataGridView1.DataSource = bookList.Rows;
        }
        //显示搜索结果(通过书籍名称或作者姓名查询)(分类查询)
        private void searchInfo(string key, string typekey)
        {
            PageList<BookInfo> searchInfo = new PageList<BookInfo>()
            .AddWhere("BookName", "like", "%" + key + "%")
            .AddWhere("BookWriter", "like", "%" + key + "%")
            .AddWhere("BookType", typekey)
            .Select();
            dataGridView1.DataSource = searchInfo.Rows;
        }
        //加载下拉框
        private void TypeList()
        {
            PageList<BookType> typelist = ORMSupport.PageSelect<BookType>()
                .Select();
            foreach (BookType item in typelist.Rows)
            {
                comboBox1.Items.Add(item.BType);
            }
        }

        private void TcInfo_Load(object sender, EventArgs e)
        {
            showBookInfo();
            TypeList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKey = textBox1.Text;
            string typeKey = comboBox1.Text;
            searchInfo(searchKey, typeKey);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
