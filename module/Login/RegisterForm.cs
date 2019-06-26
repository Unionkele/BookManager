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
using NetDB.Core.Condition;

namespace BookManager.module.Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegCheck()
        {
            if(tbRegName.Text!=""&&tbRegPwd.Text!=""){
                long PersonCount = ORMSupport.Count(new Person(), new Where()
                            .Add("PersonNum",tbRegName.Text));
                if (PersonCount <= 0)
                {
                    Person pReg = new Person();
                    pReg.PersonNum = tbRegName.Text;
                    pReg.PersonCode = tbRegPwd.Text;
                    int res= pReg.Save();
                    if (res>0)
                    {                  
                        MessageBox.Show("注册成功", "提示信息");
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("用户已存在", "提示信息");
                    return;
                }
            }
            else
            {
                if (tbRegName.Text == "")
                {
                    lbName.Visible = true;
                }
                else
                {
                    lbName.Visible = false;
                }
                if (tbRegPwd.Text == "")
                {
                    lbPwd.Visible = true;
                }
                else
                {
                    lbPwd.Visible = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubReg_Click(object sender, EventArgs e)
        {
            RegCheck();
        }
    }
}
