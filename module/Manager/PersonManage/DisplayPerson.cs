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
using BookManager.module.Manager.PersonManage;

namespace BookManager.module.Manager.PersonManager
{
    public partial class DisplayPerson : Form
    {
        public DisplayPerson()
        {
            InitializeComponent();
        }
        //加载初始信息
        public void ShowPersonInfo()
        {
            PageList<Person> page = ORMSupport.PageSelect<Person>()
                .Select();
            dataGridView1.DataSource = page.Rows;
        }
        private void DisplayPerson_Load(object sender, EventArgs e)
        {
            ShowPersonInfo();
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
            Person delInfo = new Person();
            delInfo.ID = ID;
            MessageBox.Show(delInfo.Delete() == 1 ? "删除成功！" : "删除失败！");
            ShowPersonInfo();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonInfo AddForm = new AddPersonInfo();
            AddForm.Owner = this;
            AddForm.ShowDialog();
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
            EditPersonInfo EditForm = new EditPersonInfo();
            EditForm.Owner = this;
            EditForm.EditID = ID;
            EditForm.ShowDialog();
        }
    }
}
