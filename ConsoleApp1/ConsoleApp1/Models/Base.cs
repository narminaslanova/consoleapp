using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Base
    {
        public static List<Book> Booklist { get; protected set; }
        public static List<Author> Authorlist { get; protected set; }
        public static List<Genre> Genrelist { get; protected set; }
        public static List<Customer> Customerlist { get; protected set; }

        private static int _id;
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                _id = value;
            }
        }

        private static int _count = 1;
        public Base()
        {
            _id = ++_count;
        }
    }
}
