using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetDB.Core;
using NetDB.Core.Condition;
using NetDB.Core.SqlAttribute;

namespace BookManager.model
{
    class Manager : ORMSupport
    {
        //管理员名
        private string _ManagerName;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string ManagerName
        {
            get { return _ManagerName; }
            set { _ManagerName = value; }
        }
        //登录密码
        private string _ManagerCode;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string ManagerCode
        {
            get { return _ManagerCode; }
            set { _ManagerCode = value; }
        }
        //权限等级（超级管理员）
        private bool _Manage;
        [Colmun(Type = "bit")]
        public bool Manage
        {
            get { return _Manage; }
            set { _Manage = value; }
        }


        //权限等级（工作人员）
        private bool _Work;
        [Colmun(Type = "bit")]
        public bool Work
        {
            get { return _Work; }
            set { _Work = value; }
        }


        //权限等级（游客）
        private bool _Query;
        [Colmun(Type = "bit")]
        public bool Query
        {
            get { return _Query; }
            set { _Query = value; }
        }


    }
}
