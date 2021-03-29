using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Book:Base
    {
        public string Name { get; protected set; }
        public int Count { get; protected set; }
        public double Price { get; protected set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }

        static Book()
        {
            Booklist = new List<Book>();
        }
        public Book():base()
        {
            Booklist.Add(this);
        }
        public Book(string name, string authorName, string authorSurname,string genreName, int count, double price):this()
        {
            Name = name;
            Count = count;
            Price = price;
            Author = new Author(authorName, authorSurname);
            Genre = new Genre(genreName);

        }

        public override string ToString()
        {
            return $"{Id}-{Name}, {Author.Fullname()}\n" +
                $"Price: {Price}$\n" +
                $"Count: {Count}";
        }
    }
}
