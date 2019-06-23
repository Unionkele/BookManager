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

namespace BookManager.module.Manager.BookManager
{
    public partial class DisplayBook : Form
    {
        public DisplayBook()
        {
            showInfo();
            InitializeComponent();
        }

        private void showInfo()
        {
            PageList<BookInfo> bookList = ORMSupport.PageSelect<BookInfo>()
                .Select();
        }
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
