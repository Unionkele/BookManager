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


namespace BookManager.module.Manager.PersonManager
{
    public partial class EditPerson : Form
    {
        private string pensonID;
        public EditPerson(string ID)
        {
            InitializeComponent();
            this.pensonID = ID;
        }

        public EditPerson()
        {
            // TODO: Complete member initialization
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void penson()
        {
            Person editPenson = new Person();
            editPenson.ID = pensonID;
            editPenson.Find();
            textBox1.Text = editPenson.PersonName;
            comboBox1.Text = editPenson.PersonSex;
            textBox2.Text = editPenson.PersonPhone;
            textBox3.Text = editPenson.PersonNum;
            textBox4.Text = editPenson.PersonCode;
            textBox5.Text = Convert.ToString(editPenson.PersonMoney);
            comboBox2.Text = editPenson.PersonIdentity;
            textBox6.Text = editPenson.PersonRemark;

        }

        private void EditPerson_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
