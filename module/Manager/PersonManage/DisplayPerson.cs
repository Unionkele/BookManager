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
using BookManager.module.Manager.PersonManager;



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
            Init();
        }
        public void Init()
        {
            PageList<Person> page = ORMSupport.PageSelect<Person>()
                .Select();
            dataGridView1.DataSource = page.Rows;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
