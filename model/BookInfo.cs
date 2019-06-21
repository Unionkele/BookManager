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
    class BookInfo : ORMSupport
    {
        //书籍名称
        private string _BookName;

        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }
        //书籍作者
        private string _BookWriter;

        [Colmun(Type = "varchar(50)", IsNull = false)]
        public string BookWriter
        {
            get { return _BookWriter; }
            set { _BookWriter = value; }
        }
        //书籍出版社
        private string _BookPublish;

        [Colmun(Type = "varchar(50)")]
        public string BookPublish
        {
            get { return _BookPublish; }
            set { _BookPublish = value; }
        }
        //书籍出版时间
        private DateTime _BookDate;

        [Colmun(Type = "datetime")]
        public DateTime BookDate
        {
            get { return _BookDate; }
            set { _BookDate = value; }
        }
        //书籍价格
        private float _BookPrice;

        [Colmun(Type = "float", IsNull = false)]
        public float BookPrice
        {
            get { return _BookPrice; }
            set { _BookPrice = value; }
        }
        //书籍数量
        private int _BookNum;

        [Colmun(Type = "int", IsNull = false)]
        public int BookNum
        {
            get { return _BookNum; }
            set { _BookNum = value; }
        }
        //书籍类别
        private string _BookType;

        [Colmun(Type = "varchar(50)")]
        public string BookType
        {
            get { return _BookType; }
            set { _BookType = value; }
        }
        //书籍备注
        private string _BookRemark;

        [Colmun(Type = "varchar(255)")]
        public string BookRemark
        {
            get { return _BookRemark; }
            set { _BookRemark = value; }
        }

    }
}
