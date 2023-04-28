namespace BooksLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bk1 = new Book("Sebi", "Fram", "genr1");
            Book bk2 = new Book("Dragos", "Ursu", "genr2");
            Book bk3 = new Book("Sebi", "Pupaza", "genr1");

            IPrinter genrP = new PrinterByGenre();
            IPrinter authP = new PrinterByAuthor();

            Library lib = new Library(new List<Book>() { bk1, bk2, bk3 }, authP);

            lib.Display("Sebi");
            Console.WriteLine();

            lib.Printer = genrP;
            lib.Display("genr1");
            Console.WriteLine();

            Book bk4 = new Book("Sebi", "Pupaza", "genr2");

            Console.WriteLine(lib.BookExists(bk1));
            Console.WriteLine(lib.BookExists(bk4));
        }
    }
}