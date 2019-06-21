using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NetDB.Core;
using BookManager.model;

namespace BookManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            createTb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
        static void createTb()
        {
            SqlHelper.Config("BookDataBase");
            new BookInfo().CreateTable();
            new BookOut().CreateTable();
            new BookType().CreateTable();
            new IdentityInfo().CreateTable();
            new Manager().CreateTable();
            new Person().CreateTable();
        }
    }
}
