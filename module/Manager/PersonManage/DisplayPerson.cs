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
        public DisplayPerson(string ID)
        {
            InitializeComponent();
        }

        public DisplayPerson()
        {
            // TODO: Complete member initialization
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
            //deteperson win = new deteperson(); win.Show();
            int count = dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("未选中行！");
                return;
            }
            String ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            //new  Person (ID).Show();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deteperson win = new deteperson(); win.Show();
            string ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString();
             Person info = new Person();
            info.ID = ID;
            info.Delete();
            PageList<Person> page = ORMSupport.PageSelect<Person>()
                .Select();
            dataGridView1.DataSource = page.Rows;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //selectperson win = new selectperson(); win.Show();
            PageList<Person> page = ORMSupport.PageSelect<Person>()
                .AddWhere("PersonName", textBox1.Text)
                .Select();
            dataGridView1.DataSource = page.Rows;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
