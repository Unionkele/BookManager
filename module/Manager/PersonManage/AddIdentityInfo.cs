using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookManager.model;
using NetDB.Core;
using NetDB.Core.Condition;
using NetDB.Core.SqlAttribute;

namespace BookManager.module.Manager.PersonManage
{
    public partial class AddIdentityInfo : Form
    {
        public AddIdentityInfo()
        {
            InitializeComponent();
        }
        //用户类型添加
        private void AddIdentity()
        {
            if (tbIndentity.Text != "" && tbLongTime.Text != "" && tbBigNum.Text != "")
            {
                IdentityInfo AddInfo = new IdentityInfo();
                AddInfo.IdentityType = tbIndentity.Text;
                AddInfo.LongTime = Convert.ToInt32(tbLongTime.Text);
                AddInfo.BigNum = Convert.ToInt32(tbBigNum.Text);
                int res = AddInfo.Save();
                if (res > 0)
                {
                    DisplayIdentitycs display =(DisplayIdentitycs)this.Owner;
                    display.showIdentityInfo();
                    MessageBox.Show("添加成功", "信息提示");
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("添加失败", "信息提示");
                    return;
                }
            }
            else
            {
                if (tbIndentity.Text == "")
                {
                    lbIdentityMes.Visible = true;
                }
                else
                {
                    lbIdentityMes.Visible = false;
                }
                if (tbLongTime.Text == "")
                {
                    lbLongTimeMes.Visible = true;
                }
                else
                {
                    lbLongTimeMes.Visible = false;
                }
                if (tbBigNum.Text == "")
                {
                    lbBigNumMes.Visible = true;
                }
                else
                {
                    lbBigNumMes.Visible = false;
                }
            }
        }
        //清除输入框
        private void ClearInput()
        {
            tbIndentity.Clear();
            tbLongTime.Clear();
            tbBigNum.Clear();
        }
        private void AddInfoBtn_Click(object sender, EventArgs e)
        {
            AddIdentity();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
