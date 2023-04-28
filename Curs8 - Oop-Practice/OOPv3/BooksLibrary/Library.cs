using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary
{
    internal class Library
    {
		private List<Book> bookList;

		public List<Book> BookList
		{
			get { return bookList; }
			set { bookList = value; }
		}

        private IPrinter printer;

		public IPrinter Printer
		{
			get { return printer; }
			set { printer = value; }
		}

		public Library(List<Book> bookList, IPrinter printer)
		{
			this.bookList = bookList;
			this.printer = printer;
		}

		public void Display(string ch)
		{
			printer.Diplay(bookList, ch);
		}

		public bool BookExists(Book book)
		{
			return bookList.Contains(book);
		}
	}
}
