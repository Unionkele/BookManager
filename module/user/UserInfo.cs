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
using BookManager.model;

using NetDB.Core;
using NetDB.Core.Support;
using BookManager.model;

namespace BookManager.module.user
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        string strname, sqlname, strphone, sqlphone, strnum, sqlnum, strsql = "";
        string[] sqlcode = new string[4];
        private void button1_Click(object sender, EventArgs e)
        {
            PageList<Person> per_info = new PageList<Person>();
            PageList<BookInfo> books = new PageList<BookInfo>();
            PageList<BookOut> bookout = new PageList<BookOut>();

            #region
            strsql = "select * from Person where ";
            if (textBox_name.Text != "")
            {
                strname = textBox_name.Text;
                per_info.AddWhere("PersonName", textBox_name.Text);

                sqlcode[0] = "PersonName=@strname";
            }
            if (textBox_num.Text != "")
            {
                strnum = textBox_num.Text;
                per_info.AddWhere("PersonNum", textBox_num.Text);

                sqlcode[1] = "PersonNum=@strnum";

            }
            if (textBox_phone.Text != "")
            {
                strphone = textBox_phone.Text;
                per_info.AddWhere("PersonPhone", textBox_phone.Text);

                sqlcode[2] = "PersonPhone=@strphone";
            }
            string sql_where = "";
            for (int i = 1; i < sqlcode.Length; i++)
            {
                sql_where += sqlcode[i - 1];
                if (sqlcode[(i)] != null)
                {
                    sql_where += " and ";
                }
            }
            strsql += sql_where;
            #endregion
            per_info.Select();
            textBox_money.Text = Convert.ToString(per_info.Rows[0].PersonMoney);
            //
            bookout.AddWhere("PersonID", per_info.Rows[0].ID);
            bookout.Select();
            books.AddWhere("ID", bookout.Rows[0].BookID).Select();
            dataGridView_books.DataSource = books.Rows;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_name.Text = textBox_num.Text = textBox_phone.Text = textBox_money.Text = "";

        }
    }
}
