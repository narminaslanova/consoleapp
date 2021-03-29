using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Author:Base
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }

        static Author()
        {
            Authorlist = new List<Author>();
        }
        public Author():base()
        {
            Authorlist.Add(this);
        }
        public Author(string name, string surname):this()
        {
            Name = name;
            Surname = surname;
        }

        public string Fullname()
        {
            return $"{Name} {Surname}";
        }
    }
}
