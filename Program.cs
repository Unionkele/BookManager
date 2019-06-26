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
            //createAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayPerson());



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
        //static void createAdmin()
        //{
        //    Manager mAdmin = new Manager();
        //    mAdmin.ManagerName = "admin";
        //    mAdmin.ManagerCode = "123456";
        //    mAdmin.Save();
        //}
    }
}
