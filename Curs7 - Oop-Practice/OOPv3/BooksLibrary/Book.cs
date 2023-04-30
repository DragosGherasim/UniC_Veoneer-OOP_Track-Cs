using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary
{
    internal class Book
    {
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string genre;
        public string Genre 
        {
            get { return genre; }
            set { genre = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Book(string author, string title, string genre)
        {
            this.author = author;
            this.title = title;
            this.genre = genre;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Book Title : {title}, Author : {author}, Genre : {genre}");
        }
    }
}
