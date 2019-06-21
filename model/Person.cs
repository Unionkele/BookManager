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
    class Person:ORMSupport
    {
        //用户姓名
        private string _PersonName;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string PersonName
        {
            get { return _PersonName; }
            set { _PersonName = value; }
        }
        //用户性别
        private string _PersonSex;
        [Colmun(Type = "varchar(4)", IsNull = false)]
        public string PersonSex
        {
            get { return _PersonSex; }
            set { _PersonSex = value; }
        }
        //用户电话
        private string _PersonPhone;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string PersonPhone
        {
            get { return _PersonPhone; }
            set { _PersonPhone = value; }
        }
        //用户账号
        private string _PersonNum;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string PersonNum
        {
            get { return _PersonNum; }
            set { _PersonNum = value; }
        }
        //用户密码
        private string _PersonCode;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string PersonCode
        {
            get { return _PersonCode; }
            set { _PersonCode = value; }
        }
        //余额
        private float _PersonMoney;
        [Colmun(Type = "float", IsNull = false)]
        public float PersonMoney
        {
            get { return _PersonMoney; }
            set { _PersonMoney = value; }
        }
        //用户类别
        private string _PersonIdentity;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string PersonIdentity
        {
            get { return _PersonIdentity; }
            set { _PersonIdentity = value; }
        }
        //备注
        private string _PersonRemark;
         [Colmun(Type = "varchar(255)")]
        public string PersonRemark
        {
            get { return _PersonRemark; }
            set { _PersonRemark = value; }
        }

    }
}
