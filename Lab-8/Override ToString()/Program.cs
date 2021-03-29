using System;

namespace Override_ToString__

{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product()
            {
                Id = 101,
                Name = "Pen",
                Price = 5000
            };

            Console.WriteLine(p.ToString());

        }
    }
}