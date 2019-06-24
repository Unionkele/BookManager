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

namespace BookManager.module.book
{
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            //List<BookInfo> list = Database.FindAll<BookInfo>();
            //dataGridView1.DataSource = list;
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
