using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Entities
{
    public class Product
    {
        public static int AutoIncreament = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ProductCategory { get; set; }
        public string Description { get; set; }
        public int SellingPrice { get; set; }
        public string ShortCode { get; set; }

        public Product()
        {
            AutoIncreament++;
            Id = AutoIncreament;
        }
    }
}
