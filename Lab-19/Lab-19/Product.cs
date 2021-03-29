using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_19
{
    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return ($"id : {Id} title : {Title} price : {Price}");
        }
    }
}
