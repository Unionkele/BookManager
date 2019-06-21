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
    class BookType:ORMSupport
    {
        //书籍类别
        private string _BType;
        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string BType
        {
            get { return _BType; }
            set { _BType = value; }
        }
        //备注
        private string _BRemark;
        [Colmun(Type = "varchar(255)")]
        public string BRemark
        {
            get { return _BRemark; }
            set { _BRemark = value; }
        }
    }
}
