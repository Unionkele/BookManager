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

namespace BookManager.module.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginCheck(string identity)
        {
            switch (identity)
            {
                case "普通用户":
                    if (tbLoginName.Text != "" && tbLoginPwd.Text != "")
                    {
                        Person person = new Person();
                        person.PersonNum = tbLoginName.Text;                     
                        bool res = person.Find();
                        if (res)
                        {
                            person.PersonNum = tbLoginName.Text;  
                            person.PersonCode = tbLoginPwd.Text; 
                            person.Find();
                            if (person.Find())
                            {
                                MessageBox.Show("登录成功","提示信息");
                                this.Hide();
                                new MainForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("用户或密码错误","提示信息");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户不存在","提示信息");
                        }
                    }
                    break;
                case "管理者":
                    if (tbLoginName.Text != "" && tbLoginPwd.Text != "")
                    {
                        model.Manager mLogin = new model.Manager();
                        mLogin.ManagerName = tbLoginName.Text;
                        bool res = mLogin.Find();
                        if (res)
                        {
                            mLogin.ManagerName = tbLoginName.Text;
                            mLogin.ManagerCode = tbLoginPwd.Text;
                            mLogin.Find();
                            if (mLogin.Find())
                            {
                                MessageBox.Show("登录成功", "提示信息");
                                this.Hide();
                                new Manager.BookManage.DisplayBook().Show();
                            }
                            else
                            {
                                MessageBox.Show("用户或密码错误", "提示信息");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户不存在", "提示信息");
                        }

                    }
                    break;
            }
        }

        private void subLogin_Click(object sender, EventArgs e)
        {
            string LoginType = cbLoginer.Text;
            LoginCheck(LoginType);
        }

    }
}
