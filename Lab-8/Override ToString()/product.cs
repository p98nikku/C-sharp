using System;
using System.Collections.Generic;
using System.Text;

namespace Override_ToString__
{

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            string s = this.Id + " " + this.Name + " " + this.Price;

            return s;
        }

    }
}