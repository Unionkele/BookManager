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
    public partial class DisplayBook : Form
    {
        
        public DisplayBook()
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
        private void searchInfo(string key,string typekey)
        {
            PageList<BookInfo> searchInfo = new PageList<BookInfo>()
            .AddWhere("BookName", "like", "%" + key + "%")
            .AddWhere("BookWriter", "like", "%" + key + "%")
            .AddWhere("BookType",typekey)
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
                cbSearchType.Items.Add(item.BType);
            }
        }
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookInfo AddFrom = new AddBookInfo();
            AddFrom.Owner = this;
            AddFrom.ShowDialog();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("未选中行！");
                return;
            }
            String ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            EditBookInfo EditForm = new EditBookInfo();
            EditForm.Owner = this;
            EditForm.EditID = ID;
            EditForm.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("未选中行！");
                return;
            }
            String ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            BookInfo delInfo = new BookInfo();
            delInfo.ID = ID;
            MessageBox.Show(delInfo.Delete() == 1 ? "删除成功！" : "删除失败！");
            showBookInfo();
        }

        private void DisplayBook_Load(object sender, EventArgs e)
        {
            showBookInfo();
            TypeList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchKey = tbsearch.Text;
            string typeKey = cbSearchType.Text;
            searchInfo(searchKey,typeKey);
        }

        private void 书籍类别管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DisplayBookType().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
