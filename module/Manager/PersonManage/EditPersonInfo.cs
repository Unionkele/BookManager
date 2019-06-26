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

namespace BookManager.module.Manager.PersonManage
{
    public partial class EditPersonInfo : Form
    {
        public string EditID;
        public EditPersonInfo()
        {
            InitializeComponent();
        }
        private void loadEditInfo()
        {
            Person pInfo = new Person();
            pInfo.ID=EditID;
            pInfo.Find();
            setPersonName.Text = pInfo.PersonName;
            setPersonSex.Text = pInfo.PersonSex;
            setPersonPhone.Text = pInfo.PersonPhone;
            setPersonNum.Text = pInfo.PersonNum;
            setPersonMoney.Text = Convert.ToString(pInfo.PersonMoney);
            setPersonIdentity.Text = pInfo.PersonIdentity;
            setPersonRemark.Text = pInfo.PersonRemark;
        }
        private void SubInfo()
        {

        }

        private void editPerson_Click(object sender, EventArgs e)
        {

        }

        private void EditPersonInfo_Load(object sender, EventArgs e)
        {
            loadEditInfo();
        }
    }
}
