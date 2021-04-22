using ProductCatalog.Entities;
using ProductCatalog.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnCategory
    {
        public static List<Category> categoryList = new List<Category>
        {
                new Category
                {
                    Name="Grocery",
                    Description="Necessary Items",
                    ShortCode="Groc"
                },
                new Category
                {
                    Name="Technology",
                    Description= "Gadgets",
                    ShortCode="Tech"
                },
                new Category
                {
                    Name="Stationary",
                    Description="School Items",
                    ShortCode="Stud"
                }
        };
        ShortCodeValidation shortcodevalidation = new ShortCodeValidation();

        public void AddCategory()
        {
            Console.Clear();
            Console.WriteLine("Enter Category Details :");
            Console.WriteLine($"ID : {Category.AutoIncreament}\n");
            Console.WriteLine("Enter New Category Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();
            Console.WriteLine("\nEnter Short Code : ");
            string shortCode = shortcodevalidation.ShortCodeValidatingCategory();
            categoryList.Add(new Category
            {
                Name = name,
                Description = description,
                ShortCode=shortCode
            });
            Console.WriteLine("New Catogery Added");
        }
        public void DisplayCategories()
        {
            Console.Clear();
            Console.WriteLine("Catogriess Are:");
            foreach (Category category in categoryList)
            {
                Console.WriteLine("Id : " + category.Id + 
                    "\nName : " + category.Name + 
                    "\nDescription : " + category.Description + 
                    "\nShort Code : " + category.ShortCode);
            }
            Console.ReadKey();
            Console.WriteLine("Press enter to continue");
            Console.Clear();

        }
        public void DeleteCategory()
        {
            Console.Clear();
            bool ExitDelete = false;
            while (ExitDelete != true)
            {
                Console.WriteLine("----- Deleting Category");
                Console.WriteLine("a. Delete by Name");
                Console.WriteLine("b. Delete by Id ");
                Console.WriteLine("c. Delete by Short Code ");
                Console.WriteLine("d. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter Name : ");
                        string inputName = Console.ReadLine();
                        Category findname = categoryList.Single(single => inputName == single.Name);
                        categoryList.Remove(findname);
                        OperationOnProduct.ProductList.RemoveAll(finding => finding.ProductCategory == inputName);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "b":
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var findid = categoryList.Single(single => id == single.Id);
                        categoryList.Remove(findid);
                        OperationOnProduct.ProductList.RemoveAll(finding => finding.ProductCategory == findid.Name);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "c":
                        Console.WriteLine("Enter Short Code : ");
                        string ShortCode = Console.ReadLine();
                        Category findshortcode = categoryList.Single(single => ShortCode == single.ShortCode);
                        categoryList.Remove(findshortcode);
                        OperationOnProduct.ProductList.RemoveAll(finding => finding.ProductCategory == findshortcode.Name);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "d":
                        ExitDelete = true;
                        Console.WriteLine("Exiting..............");
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;
                }
                Console.WriteLine("Press enter to continue");
                Console.Clear();
            }


        }
        public void SearchCategory()
        {
            Console.Clear();
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("a. By Id");
                Console.WriteLine("b. By Name");
                Console.WriteLine("c. By Short Code");
                Console.WriteLine("d. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter Id To Search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var Prod = categoryList.Single(single => id == single.Id);
                        Console.WriteLine("\nID : " + Prod.Id);
                        Console.WriteLine("\nName : " + Prod.Name);
                        Console.WriteLine("\nDescription : " + Prod.Description);
                        //Console.WriteLine("Found Succesfully");
                        break;
                    case "b":
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = categoryList.Single(single => name == single.Name);
                        Console.WriteLine("Product Id - " + findname.Id + " Name - " + findname.Name + " Description - " + findname.Description);
                        break;
                    case "c":
                        Console.WriteLine("Enter Short Code");
                        string ShortCode = Console.ReadLine();
                        var findcategory = categoryList.Single(single => ShortCode == single.ShortCode);
                        //Console.WriteLine("\nID : " + Products.Id);
                        //Console.WriteLine("\nName : " + Product.Name);
                        //Console.WriteLine("\nDescription : " + Product.Description);
                        Console.WriteLine(findcategory.ToString());
                        Console.WriteLine("Found Succesfully");
                        break;
                    case "d":
                        ExitSearch = true;
                        Console.WriteLine("Exiting");
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;

                }
                Console.WriteLine("Press enter to continue");
                Console.Clear();

            }
        }
    }
}
