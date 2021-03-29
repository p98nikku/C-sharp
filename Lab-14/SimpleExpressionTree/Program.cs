using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleExpressionTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Title = "PEN",
                    Price = 100,
                    Owner = "Foo"
                },
                new Product
                {
                    Id = 2,
                    Title = "PEN",
                    Price = 400,
                    Owner = "koo"
                },
                new Product
                {
                    Id = 3,
                    Title = "PEN",
                    Price = 100,
                    Owner = "MOo"
                }

            };


            var owners = products.Where(p => p.Price > 300).Select(p => new { p.Owner }).ToList();
            owners.ForEach(o => Console.WriteLine(o));
            var o = (from r in products where r.Price > 300 select new { r.Id, r.Owner }).ToList();
            o.ForEach(i => Console.WriteLine(i));

            //Console.WriteLine("Hello World!");
            //Func<int, int> square = (x) => x * x;
            //System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            //var a = e.Compile();
            //Console.WriteLine(e);
            //Console.WriteLine(a(5));
        }
    }
}

