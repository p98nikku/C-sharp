using ProductCatalog.OperationOnEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Entities
{
    public class Catalog
    {
        OperationOnCategory operationOnCategory = new OperationOnCategory();
        OperationOnProduct operationOnProduct = new OperationOnProduct();

        public void DisplayCatalog()
        {
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("SELECT YOUR TYPE -----");
                Console.WriteLine("\n               a. Category");
                Console.WriteLine("\n               b. Product");
                Console.WriteLine("\n               c. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.Clear();
                        this.CategoryCatalog();
                        exit = true;
                        break;
                    case "b":
                        Console.Clear();
                        this.ProductCatalog();
                        exit = true;
                        break;
                    case "c":
                        exit = true;
                        Console.WriteLine("Exiting back to the main menu");
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
        public void ProductCatalog()
        {
            bool ExitProduct = false;
            while (ExitProduct != true)
            {
                Console.WriteLine("OPERATIONS ON PRODUCT");
                Console.WriteLine("\n                   a. Add a Product");
                Console.WriteLine("\n                   b. Display all Products");
                Console.WriteLine("\n                   c. Delete a Product");
                Console.WriteLine("\n                   d. Search a Product");
                Console.WriteLine("\n                   e. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        operationOnProduct.AddProduct();
                        break;
                    case "b":
                        operationOnProduct.DisplayProduct();
                        break;
                    case "c":
                        operationOnProduct.DeleteProduct();
                        break;
                    case "d":
                        operationOnProduct.SearchProduct();
                        break;
                    case "e":
                        ExitProduct = true;
                        Console.WriteLine("Exiting");
                        Console.Clear();
                        this.DisplayCatalog();
                        break;
                    default:
                        Console.WriteLine("Try Again");

                        break;
                }
            }
        }
        public void CategoryCatalog()
        {
            bool ExitCategory = false;
            while (ExitCategory != true)
            {
                Console.WriteLine("OPERATIONS ON CATEGORY");
                Console.WriteLine("\n                    a. Add a Category");
                Console.WriteLine("\n                    b. Display a Category");
                Console.WriteLine("\n                    c. Delete a Category");
                Console.WriteLine("\n                    d. Search a Category");
                Console.WriteLine("\n                    e. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        operationOnCategory.AddCategory();
                        break;
                    case "b":
                        operationOnCategory.DisplayCategories();
                        break;
                    case "c":
                        operationOnCategory.DeleteCategory();
                        break;
                    case "d":
                        operationOnCategory.SearchCategory();
                        break;
                    case "e":
                        ExitCategory = true;
                        Console.WriteLine("Exiting");
                        Console.Clear();
                        this.DisplayCatalog();
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;

                }
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
