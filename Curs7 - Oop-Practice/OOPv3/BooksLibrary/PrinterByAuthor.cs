using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary
{
    internal class PrinterByAuthor : IPrinter
    {
        public void Diplay(List<Book> bookList, string authorName)
        {
            bookList.Where(book => book.Author == authorName).ToList().ForEach(book => book.DisplayBook());
        }
    }
}
