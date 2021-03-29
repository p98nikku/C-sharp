using System;
using System.Linq;
using System.Collections.Generic;
namespace LambdaExpression2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!--------------!");

            Intobj<int> intobj = new Intobj<int>()
            { intobj = 9 };

            List<Product> product = new List<Product>()
            {

                new Product
                {
                    Id = 01,
                    Owner = "a1",
                    Price = 400
                },

                new Product
                {
                Id = 02,
                Owner = "a2",
                Price = 500
                },
            
            };



            List<Distributed> distributed = new List<Distributed>()
            {

                new Distributed
                {
                    D_Id = 101,
                    D_Owner = "b1",
                    Product_id  = 01
                },

                new Distributed
                {
                D_Id = 102,
                D_Owner = "b2",
                Product_id  = 02
                },

                new Distributed
                {
                D_Id = 103,
                D_Owner = "b3",
                Product_id  = 03
                }

            };

            var productanddist = product.Zip(distributed, (p, d) => p.Id + " " + d.D_Owner);

            foreach (var pd in productanddist)
                Console.WriteLine(pd);











            //Console.WriteLine("expression: ");
            //var owner = product.Where(p => p.Price > 300).Select(p => (p.Id, p.Owner)).ToList();
            //owner.ForEach(o => Console.WriteLine(o));

            ////var id = product.Where(p => p.Price > 300).Select(p => p.Id).ToList();
            ////id.ForEach(i => Console.WriteLine(i));

            //Console.WriteLine("Linq: ");
            //var owner2 = (from p in product where (p.Price > 300 && p.Id == 1) select new { p.Id, p.Owner }).ToList();
            //owner2.ForEach(o => Console.WriteLine(o));

            //var result = product.Zip(distributed, (Id, D_Id) => (Id, D_Id)).ToList();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //result.ForEach(d => Console.WriteLine(d));


        }
    }
}
