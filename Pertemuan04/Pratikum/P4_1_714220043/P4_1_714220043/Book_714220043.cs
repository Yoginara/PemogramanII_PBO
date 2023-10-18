using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220043
{
    public class Book_714220043: Product_714220043 
    {
        protected string pageCount;

        public Book_714220043(string type, string title, string pagecount) : base(type,title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
