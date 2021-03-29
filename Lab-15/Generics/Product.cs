
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            string s = "Id: " + this.Id + " " + "Name: " + this.Name + " " + "Price: " + this.Price;
            return s;
        }

    }
}