using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            GenericClass<Product> gn = new GenericClass<Product>();
            Product p = new Product()
            {
                Id = 1,
                Name = "pen",
                Price = 30
            };

            gn.display(p);

        }
    }
}
