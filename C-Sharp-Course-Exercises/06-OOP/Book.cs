using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._06_OOP
{
    internal class Book
    {
        private string _title;
        private int _pages;

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == "")
                {
                    _title = "Unknown";
                }
                else
                {
                    _title = value;
                }
            }
        }

        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value < 1)
                {
                    _pages = 1;
                }
                else
                {
                    _pages = value;
                }
            }
        }

        public Book()
        {
            _title = "Unknown";
            _pages = 1;
        }
    }
}
