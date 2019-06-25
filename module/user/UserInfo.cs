using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager.module.user
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        string strname, strphone, strnum;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "") 
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_name.Text = textBox_num.Text = textBox_phone.Text = textBox__money.Text = "";
            
        }
    }
}
