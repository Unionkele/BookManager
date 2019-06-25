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
    public partial class DisplayBookType : Form
    {
        public DisplayBookType()
        {
            InitializeComponent();
        }

        public void showTypeInfo()
        {
            PageList<BookType> typeList = new PageList<BookType>().Select();
            dataGridView1.DataSource = typeList.Rows;
        }
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookType AddTypeForm = new AddBookType();
            AddTypeForm.Owner = this;
            AddTypeForm.ShowDialog();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("未选中行！");
                return;
            }
            String ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            EditBookType EditTypeForm = new EditBookType();
            EditTypeForm.Owner = this;
            EditTypeForm.EditID = ID;
            EditTypeForm.ShowDialog();
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
            BookType delInfo = new BookType();
            delInfo.ID = ID;
            MessageBox.Show(delInfo.Delete() == 1 ? "删除成功！" : "删除失败！");
            showTypeInfo();
        }

        private void DisplayBookType_Load(object sender, EventArgs e)
        {
            showTypeInfo();
        }
    }
}
