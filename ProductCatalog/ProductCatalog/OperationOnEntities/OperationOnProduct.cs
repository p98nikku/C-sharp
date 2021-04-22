using ProductCatalog.Entities;
using ProductCatalog.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnProduct
    {
        public static List<Product> ProductList = new List<Product>
        { new Product{
         Name="Pencil",
      Manufacturer="Natraj",
      Description="Study",
      SellingPrice=10,
      ShortCode="pe10",
      ProductCategory="Stationary"
    },
            new Product
            {
      Name="Pen",
      Manufacturer="APSARA",
      Description="Study",
      SellingPrice=11,
      ShortCode="pe11",
      ProductCategory="Stationary"
            },
            new Product
            {
      Name="Lays",
      Manufacturer="Lays",
      Description="Food ITEM",
      SellingPrice=5,
      ShortCode="la05",
      ProductCategory="Grocery"
            }
        };
        ShortCodeValidation shortCodeValidation = new ShortCodeValidation();
        OperationOnCategory operationOnCategory = new OperationOnCategory();

        public void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Details : \n");
            Console.WriteLine($"ID : {Product.AutoIncreament}");
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Manufacturer Name : ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();
            Console.WriteLine("\nEnter Selling Price greater than zero: ");
            int selllingprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Short Code : ");
            string shortCode = shortCodeValidation.ShortCodeValidatingproducts();
            Console.WriteLine("\nEnter category Of Product");
            string category = Console.ReadLine();
            //bool iscategoryPresent = false;
            ProductList.Add(new Product
            {
                Name = name,
                Manufacturer = manufacturer,
                Description = description,
                SellingPrice = selllingprice,
                ProductCategory = category
            });

            Console.WriteLine("\nProduct Added succesfully\n");
            Console.WriteLine("\nPress Enter TO Continue:");
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Displaying a Product");
            foreach(Product p in ProductList)
            {
                Console.WriteLine("Id : "+p.Id  
                    +"\nName : " + p.Name 
                    + "\nDescription : " + p.Description 
                    +
                    "\nShort Code : Null\n" 
                    + "Category :" + p.ProductCategory 
                    + "\nManufacturer :" + p.Manufacturer 
                    +
                    "\n Selling Price :" + p.SellingPrice);
            }
        }
        public void DeleteProduct()
        {
            Console.Clear();
            bool ExitDelete = false;
            while(ExitDelete!=true)
            {
                Console.WriteLine("Deleting Product");
                Console.WriteLine("\n a.Deleting by id");
                Console.WriteLine("\n b. Delete by Short Code");
                Console.WriteLine("\n c.exit");
                switch(Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter ID:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var findid = ProductList.Single(s => id == s.Id);
                        ProductList.Remove(findid);
                        ExitDelete = true;
                        break;
                    case "b":
                        Console.WriteLine("Enter ShortCode : ");
                        string ShortcodeToFind = Console.ReadLine();
                        var findproduct = ProductList.Single(single => ShortcodeToFind == single.ShortCode);
                        ProductList.Remove(findproduct);
                        Console.WriteLine("Removed Successfully");
                        ExitDelete = true;
                        break;
                    case "c":
                        ExitDelete = true;
                        Console.WriteLine("Exiting the program");
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
                }
                Console.WriteLine("Press enter to continue");
                Console.Clear();
            }
        }
        public List<Product> ProductGreaterThan = new List<Product>();
        public List<Product> ProductLessThan = new List<Product>();
        public void SearchProduct()
        {
            Console.ReadKey();
            Console.Clear();
            bool ExitSearch = false;
            while(ExitSearch!=true)
            {
                Console.WriteLine("Searching a Product");
                Console.WriteLine("\n a.By ID");
                Console.WriteLine("\n b.By Name");
                Console.WriteLine("\n c. By Selling Price Greater Than");
                Console.WriteLine("\n d.By Selling Price less Than");
                Console.WriteLine("\n e.By Price");
                Console.WriteLine("\n f.exit");
                switch(Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter id ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var Prod = ProductList.Single(s => id == s.Id);
                        Console.WriteLine("\nID : " + Prod.Id);
                        Console.WriteLine("\nName : " + Prod.Name);
                        Console.WriteLine("\nManufacturer : " + Prod.Manufacturer);
                        Console.WriteLine("\nSelling Price : " + Prod.SellingPrice);
                        Console.WriteLine("\nDescription : " + Prod.Description);
                        break;
                    case "b":
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = ProductList.Single(s => name == s.Name);
                        Console.WriteLine("\nID : " + findname.Id);
                        Console.WriteLine("\nName : " + findname.Name);
                        Console.WriteLine("\nManufacturer : " + findname.Manufacturer);
                        Console.WriteLine("\nSelling Price : " + findname.SellingPrice);
                        Console.WriteLine("\nDescription : " + findname.Description);
                        break;
                    case "c":
                        Console.WriteLine("Enter Selling Price Greater Than");
                        int InputGreater = Convert.ToInt32(Console.ReadLine());
                        foreach (Product prod in ProductList)
                        {
                            if (prod.SellingPrice > InputGreater)
                            {
                                this.ProductGreaterThan.Add(prod);
                            }
                        }
                        foreach (Product output in ProductGreaterThan)
                        {
                            Console.WriteLine($"Id : {output.Id}");
                            Console.WriteLine($"Name : {output.Name}");
                            Console.WriteLine($"Manufacturer : {output.Manufacturer}");
                            Console.WriteLine($"Description : {output.Description}");
                            Console.WriteLine($"Selling Price : {output.SellingPrice}");
                            
                        }
                        break;
                    case "d":
                        Console.WriteLine("Enter Selling Price Less Than");
                        int InputLess = Convert.ToInt32(Console.ReadLine());
                        foreach (Product prod in ProductList)
                        {
                            if (prod.SellingPrice < InputLess)
                            {
                                this.ProductLessThan.Add(prod);
                            }
                        }
                        foreach (Product output1 in ProductLessThan)
                        {
                            Console.WriteLine($"Id : {output1.Id}");
                            Console.WriteLine($"Name : {output1.Name}");
                            Console.WriteLine($"Manufacturer : {output1.Manufacturer}");
                            Console.WriteLine($"Description : {output1.Description}");
                            Console.WriteLine($"Selling Price : {output1.SellingPrice}");
                            
                        }
                        break;
                    case "e":
                        Console.WriteLine("Enter Price");
                        int Equal = Convert.ToInt32(Console.ReadLine());
                        var PriceEqualsTO = ProductList.Where(s => s.SellingPrice == Equal).ToList();
                        foreach (Product p in PriceEqualsTO)
                        {
                            Console.WriteLine($"Id : {p.Id}");
                            Console.WriteLine($"Name : {p.Name}");
                            Console.WriteLine($"Manufacturer : {p.Manufacturer}");
                            Console.WriteLine($"Description : {p.Description}");
                            Console.WriteLine($"Selling Price : {p.SellingPrice}");
                        }
                        break;
                    case "f":
                        ExitSearch = true;
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}
