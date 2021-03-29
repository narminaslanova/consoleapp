using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Genre:Base
    {
        public string Name { get; protected set; }
        static Genre()
        {
            Genrelist = new List<Genre>();
        }
        public Genre():base()
        {
            Genrelist.Add(this);
        }
        public Genre(string name):this()
        {
            Name = name;
        }
    }
}
