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
    public partial class EditIdentityInfo : Form
    {
        public string EditID;
        public EditIdentityInfo()
        {
            InitializeComponent();
        }
        //加载信息
        private void loadInfo()
        {
            IdentityInfo Info = new IdentityInfo();
            Info.ID = EditID;
            Info.Find();
            EditIndentity.Text = Info.IdentityType;
            EditLongTime.Text =  Convert.ToString(Info.LongTime);
            EditBigNum.Text = Convert.ToString(Info.BigNum);
        }
        //更新信息
        private void UpdataInfo()
        {
            if (EditIndentity.Text != "" && EditLongTime.Text != "" && EditBigNum.Text != "")
            {
                IdentityInfo subInfo = new IdentityInfo();
                subInfo.IdentityType = EditIndentity.Text;
                subInfo.LongTime = Convert.ToInt32(EditLongTime.Text);
                subInfo.BigNum = Convert.ToInt32(EditBigNum.Text);
                subInfo.ID = EditID;
                int res = subInfo.Update();
                if (res > 0)
                {
                    DisplayIdentitycs display= (DisplayIdentitycs)this.Owner;
                    display.showIdentityInfo();
                    MessageBox.Show("修改成功", "提示信息");
                }
                else
                {
                    MessageBox.Show("修改失败", "提示信息");
                    return;
                }
            }
            else
            {
                if (EditIndentity.Text == "")
                {
                    lbIdentityMes.Visible = true;
                }
                else
                {
                    lbIdentityMes.Visible = false;
                }
                if (EditLongTime.Text == "")
                {
                    lbLongTimeMes.Visible = true;
                }
                else
                {
                    lbLongTimeMes.Visible = false;
                }
                if (EditBigNum.Text == "")
                {
                    lbBigNumMes.Visible = true;
                }
                else
                {
                    lbBigNumMes.Visible = false;
                }
            }
        }

        private void SubInfoBtn_Click(object sender, EventArgs e)
        {
            UpdataInfo();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditIdentityInfo_Load(object sender, EventArgs e)
        {
            loadInfo();
        }
    }
}
