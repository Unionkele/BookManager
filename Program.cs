using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NetDB.Core;
using BookManager.model;
using BookManager.module.Login;
using BookManager.module.Manager.BookManage;
using BookManager.module.Manager.PersonManager;
using BookManager.module.Manager.PersonManage;
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
            Application.Run(new DisplayPerson());
            Application.Run(new DisplayBook());



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
