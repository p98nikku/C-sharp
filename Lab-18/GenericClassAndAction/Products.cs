using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndAction
{
    public class Products
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public Products(int i, int p, string t, string o)
        {
            ID = i;
            Price = p;
            Title = t;
            Owner = o;
        }
    }
}
