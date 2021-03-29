using System;

namespace delegatesapp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDb bookdb = new BookDb();
            processBookCallDeligates pd = new processBookCallDeligates(sellBook);
            AddBook(bookdb);
           
           pd += RentBook;
            pd += scrapBook;
            bookdb.processPaperbackBook(pd);
        }
        static void AddBook(BookDb bookDb)
        {
            bookDb.AddBook("three men in a boat","undefined",300,true);
            bookDb.AddBook("the stroy of my life", "hellen keller", 350, true);
        }
        static void RentBook(Book b)
        {
            Console.WriteLine($" title = {b.Title}");
        }
        static void sellBook(Book b)
        {
            Console.WriteLine($" Price = {b.Price}");
        }
        static void scrapBook(Book b)
        {
            Console.WriteLine($" sold  = {b.Title}");
        }


    }
}
