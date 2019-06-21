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
    class IdentityInfo : ORMSupport
    {
        //借书人身份
        private string _IdentityType;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string IdentityType
        {
            get { return _IdentityType; }
            set { _IdentityType = value; }
        }
        //最大借书时长(天)
        private int _LongTime;
        [Colmun(Type = "int", IsNull = false)]
        public int LongTime
        {
            get { return _LongTime; }
            set { _LongTime = value; }
        }
        //最大借书次数
        private int _BigNum;
        [Colmun(Type = "int", IsNull = false)]
        public int BigNum
        {
            get { return _BigNum; }
            set { _BigNum = value; }
        }
    }
}
