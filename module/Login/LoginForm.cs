using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager.module.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                string seek = "select count(*) from Person where PersonName=@username";
            }
            else {
                MessageBox.Show("不能为空","提示");
            }
         

        }
    }
}
