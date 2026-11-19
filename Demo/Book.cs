using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Book
    {
        public string title;
        public int pages;


        public override string ToString()
        {
            return $"(title : {title} , pages : {pages})";
        }

    }
}
