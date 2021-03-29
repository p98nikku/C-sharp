using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression2
{
    public class Product
    {

        public int Id { get; set; }
        public string Owner { get; set; }
        public int Price{ get; set; }

        public void Display(Product p)
        {
            Console.WriteLine(p.Price);
        }
    }
}
