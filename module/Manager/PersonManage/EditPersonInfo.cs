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
    public partial class EditPersonInfo : Form
    {
        public string EditID;
        public EditPersonInfo()
        {
            InitializeComponent();
        }
        //加载编辑信息
        private void loadEditInfo()
        {
            Person pInfo = new Person();
            pInfo.ID = EditID;
            pInfo.Find();
            setPersonName.Text = pInfo.PersonName;
            setPersonSex.Text = pInfo.PersonSex;
            setPersonPhone.Text = pInfo.PersonPhone;
            setPersonNum.Text = pInfo.PersonNum;
            setPersonMoney.Text = Convert.ToString(pInfo.PersonMoney);
            setPersonIdentity.Text = pInfo.PersonIdentity;
            setPersonRemark.Text = pInfo.PersonRemark;

            setPersonNum.Enabled = false;
        }
        //提交更新信息
        private void SubInfo()
        {
            Person pSub = new Person();
            pSub.PersonName = setPersonName.Text;
            pSub.PersonSex = setPersonSex.Text;
            pSub.PersonPhone = setPersonPhone.Text;
            pSub.PersonMoney = Convert.ToSingle(setPersonMoney.Text);
            pSub.PersonIdentity = setPersonIdentity.Text;
            pSub.PersonRemark = setPersonRemark.Text;
            pSub.ID = EditID;
            int res = pSub.Update();
            if (res > 0)
            {
                DisplayPerson display = (DisplayPerson)this.Owner;
                display.ShowPersonInfo();
                MessageBox.Show("信息更新成功", "信息提示");
            }
            else
            {
                MessageBox.Show("信息更新失败", "信息提示");
            }
        }

        private void editPerson_Click(object sender, EventArgs e)
        {
            SubInfo();
        }

        private void EditPersonInfo_Load(object sender, EventArgs e)
        {
            loadEditInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
