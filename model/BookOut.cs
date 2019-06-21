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
    class BookOut : ORMSupport
    {
        //所借书籍ID
        private string _BookID;
        [Colmun(Type = "varchar(32)", IsNull = false)]
        public string BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
        //还书人ID
        private string _PersonID;
        [Colmun(Type = "varchar(32)", IsNull = false)]
        public string PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }
        //还书时间
        private DateTime _OutDate;
        [Colmun(Type = "datetime", IsNull = false)]
        public DateTime OutDate
        {
            get { return _OutDate; }
            set { _OutDate = value; }
        }
    }
}
