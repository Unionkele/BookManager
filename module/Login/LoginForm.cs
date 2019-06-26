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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginCheck(string identity)
        {
            if (tbLoginName.Text != "" && tbLoginPwd.Text != "") {
                switch (identity)
                {
                    case "普通用户":
                        long PersonCount = ORMSupport.Count(new Person(), new Where()
                            .Add("PersonNum", tbLoginName.Text));
                        if (PersonCount <= 0)
                        {
                            MessageBox.Show("用户不存在", "提示信息");
                            return;
                        }
                        else
                        {
                            Person pLogin = new Person();
                            bool b = pLogin.Find(new Where()
                                .Add("PersonNum", tbLoginName.Text)
                                .Add("PersonCode", tbLoginPwd.Text));
                            if (b)
                            {
                                MessageBox.Show("登录成功", "提示信息");
                                this.Hide();
                                new MainForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("用户名或密码输入错误", "提示信息");
                            }
                        }
                        break;
                    case "管理者":

                        long count = ORMSupport.Count(new model.Manager(), new Where()
                            .Add("ManagerName", tbLoginName.Text));
                        if (count <= 0)
                        {
                            MessageBox.Show("用户不存在", "提示信息");
                            return;
                        }
                        else
                        {
                            model.Manager mLogin = new model.Manager();
                            bool b = mLogin.Find(new Where()
                                .Add("ManagerName", tbLoginName.Text)
                                .Add("ManagerCode", tbLoginPwd.Text));
                            if (b)
                            {
                                MessageBox.Show("登录成功", "提示信息");
                                this.Hide();
                                new module.Manager.BookManage.DisplayBook().Show();
                            }
                            else
                            {
                                MessageBox.Show("用户名或密码输入错误", "提示信息");
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("请选择登录身份","提示信息");
                        break;
                }
            }
            else
            {
                MessageBox.Show("请输入登录信息","提示信息");
            }                 
        }
        

        private void subLogin_Click(object sender, EventArgs e)
        {
            string LoginType = cbLoginer.Text;
            LoginCheck(LoginType);
        }

        private void res_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
        }

    }
}
