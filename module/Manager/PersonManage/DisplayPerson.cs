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
using BookManager.module.Manager.PersonManage;


namespace BookManager.module.Manager.PersonManager
{
    public partial class DisplayPerson : Form
    {
        public DisplayPerson()
        {
            InitializeComponent();
        }

        private void DisplayPerson_Load(object sender, EventArgs e)
        {
            person();
        }
        public void person()
        {
            PageList<Person> page = ORMSupport.PageSelect<Person>()
                .Select();
            dataGridView1.DataSource = page.Rows;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPerson win = new EditPerson(); win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detepenson win = new detepenson(); win.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectpenson win = new selectpenson(); win.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
