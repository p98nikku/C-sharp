using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.OperationOnEntities;

namespace ProductCatalog.Entities
{
    public class Catalog
    {
        public static OperationOnCategory OperationOnCategory { get; set; }
        public OperationOnProducts OperationOnProducts  { get; set; }
        public Catalog()
        {
            Catalog.OperationOnCategory = new OperationOnCategory();
            this.OperationOnProducts = new OperationOnProducts();
        }
        public void DisplayCatalog()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
