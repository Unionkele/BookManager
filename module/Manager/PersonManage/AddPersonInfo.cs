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

namespace BookManager.module.Manager.PersonManage
{
    public partial class AddPersonInfo : Form
    {
        public AddPersonInfo()
        {
            InitializeComponent();
        }
        private void GetPersonInfo()
        {
            if (tbPersonNum.Text != "")
            {
                Person pInfo = new Person();
                pInfo.PersonName = tbPersonName.Text;
                pInfo.PersonSex = cbPersonSex.Text;
                pInfo.PersonPhone = tbPersonPhone.Text;
                pInfo.PersonNum = tbPersonNum.Text;
                pInfo.PersonMoney = Convert.ToSingle(tbPersonMoney.Text);
                pInfo.PersonIdentity = cbPersonIdentity.Text;
                pInfo.PersonRemark = tbPersonRemark.Text;
                pInfo.PersonCode="123456";
                int res = pInfo.Save();
                if (res > 0)
                {
                    DisplayPerson display = (DisplayPerson)this.Owner;
                    display.ShowPersonInfo();
                    MessageBox.Show("添加成功","提示信息");
                    FormClear();
                }
            }
            else
            {
                MessageBox.Show("账号不能为空","提示信息");
                return;
            }
        }
        private void FormClear()
        {
            tbPersonName.Clear();
            tbPersonPhone.Clear();
            tbPersonNum.Clear();
            tbPersonMoney.Clear();
            tbPersonRemark.Clear();
        }
        private void subPersonInfo_Click(object sender, EventArgs e)
        {
            GetPersonInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
