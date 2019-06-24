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
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddBookInfo(this).Show();
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
            new EditBookInfo(ID).Show();
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
        }

    }
}
