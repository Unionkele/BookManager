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
    public partial class DisplayIdentitycs : Form
    {
        public DisplayIdentitycs()
        {
            InitializeComponent();
        }
        //用户类型信息列表显示
        public void showIdentityInfo()
        {
            PageList<IdentityInfo> IdentityList = ORMSupport.PageSelect<IdentityInfo>()
                .Select();
            dataGridView1.DataSource = IdentityList.Rows;
        }
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIdentityInfo AddFrom = new AddIdentityInfo();
            AddFrom.Owner = this;
            AddFrom.ShowDialog();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("未选中行！");
                return;
            }
            String ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            EditIdentityInfo EditForm = new EditIdentityInfo();
            EditForm.Owner = this;
            EditForm.EditID = ID;
            EditForm.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("未选中行！");
                return;
            }
            String ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            IdentityInfo delInfo = new IdentityInfo();
            delInfo.ID = ID;
            MessageBox.Show(delInfo.Delete() == 1 ? "删除成功！" : "删除失败！");
            showIdentityInfo();
        }
    }
}
