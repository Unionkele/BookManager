using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManager.module.Login;
using BookManager.module.Manager.BookManage;
using BookManager.module.Manager.PersonManager;

namespace BookManager
{
    public partial class MainForm : Form
    {
        Sunisoft.IrisSkin.SkinEngine Skin1;
        public MainForm()
        {
            InitializeComponent();
             //皮肤
            Skin1 = new Sunisoft.IrisSkin.SkinEngine();
            Skin1.SkinFile = Environment.CurrentDirectory + ConfigurationSettings.AppSettings["sk"].ToString();
        }             
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void 书籍管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                BookManager.module.Login.LoginForm loginF = new BookManager.module.Login.LoginForm();
                loginF.Owner = this;
                loginF.ShowDialog();
            }
            else
            {
                DisplayBook book = new DisplayBook();
                book.Owner = this;
                book.ShowDialog();
            }
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                BookManager.module.Login.LoginForm loginF = new BookManager.module.Login.LoginForm();
                loginF.Owner = this;
                loginF.ShowDialog();
            }
            else
            {
                DisplayPerson person = new DisplayPerson();
                person.Owner = this;
                person.ShowDialog();
            }
        }
       
    }
}
