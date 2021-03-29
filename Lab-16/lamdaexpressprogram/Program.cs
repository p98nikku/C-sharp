using System;
using System.Collections.Generic;
using System.Linq;

namespace lamdaexpressprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello World!");
            List<product> products = new List<product>();
            {
                products.Add(new product {Id= 1, Title="A", Owner="O1",Price= 40 }) ;
                products.Add(new product { Id = 2, Title = "B", Owner = "O2", Price = 4 });
                products.Add(new product { Id = 3, Title = "C", Owner = "O3", Price = 400 });
                products.Add(new product { Id = 4, Title = "D", Owner = "O4", Price = 4000 });

                products.Add(new product { Id = 5, Title = "E", Owner = "O5", Price = 500 });
                products.Add(new product { Id = 6, Title = "F", Owner = "O6", Price = 700 });

                products.Add(new product { Id = 7, Title = "G", Owner = "O7", Price = 900 });

                products.Add(new product { Id = 8, Title = "H", Owner = "O8", Price = 30 });


            };
            Console.WriteLine("Using Lambda expression\n");
            var owners = products.Where(p => p.Price > 300).Select(p => p.Owner).ToList();
            owners.ForEach(o => Console.WriteLine(o));
            Console.WriteLine("Using Linq\n");
            var names = from r in products where (r.Price >300 && r.Id == 6) select  new { r.Id,r.Owner };
            names.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
