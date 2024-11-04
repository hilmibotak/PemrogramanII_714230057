﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230057
{
    internal class Book_714230057 : Product_714230057
    {
        public string pageCount;

        public Book_714230057(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        //Implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount);
        }
    }
}
