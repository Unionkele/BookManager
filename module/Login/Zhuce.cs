using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using NetDB.Core;
using BookManager.model;
>>>>>>> 0305b9003623cb6f0a31e02bab5de157078e505c

namespace BookManager.module.Login
{
    public partial class Zhuce : Form
    {
        public Zhuce()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            per.PersonName = textBox1.Text;
            per.PersonSex = textBox2.Text;
            per.PersonPhone = textBox3.Text;
            per.PersonNum = textBox4.Text;
            per.PersonCode = textBox5.Text;
            per.PersonMoney = Convert.ToSingle(textBox6.Text);
            per.PersonIdentity = textBox7.Text;
            per.PersonRemark = textBox8.Text;
            int rein = per.Save();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            if (rein == 0)
            {
                MessageBox.Show("注册失败","提示信息");
            }
            else {
                MessageBox.Show("注册成功","提示信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
