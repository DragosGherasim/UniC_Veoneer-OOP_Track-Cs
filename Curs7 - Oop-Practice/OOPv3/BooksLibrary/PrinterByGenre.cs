using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary
{
    internal class PrinterByGenre: IPrinter
    {
        public void Diplay(List<Book> bookList, string genre)
        {
            bookList.Where(book => book.Genre == genre).ToList().ForEach(book => book.DisplayBook());
        }

    }
}
