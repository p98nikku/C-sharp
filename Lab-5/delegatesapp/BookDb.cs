using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace delegatesapp
{
    public delegate void processBookCallDeligates(Book book);
     public class BookDb
    {
        ArrayList list = new ArrayList();

        public void AddBook(string title, string author, decimal price, bool paperback)
        {
            list.Add(new Book
            {
                Title = title,
                Author=author,
                Price=price,
                Paperack=paperback

            });

        }
        public void processPaperbackBook(processBookCallDeligates processBook)
        {
            foreach(Book b in list)
            {
                if(b.Paperack)
                {
                    processBook(b);
                }
            }
        }


    }
}
