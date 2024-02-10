using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            char select;
            string ProductName;
            double Price;

            List<Product> products = new List<Product>();


            Console.WriteLine("Are there new products to be added to the inventory? [Y/N]");
            select = Convert.ToChar(Console.ReadLine());
            select = char.ToUpper(select);

            if (select == 'Y')
            {
                // Loop for adding items to inventory
                while (select == 'Y')
                {
                    Console.WriteLine($"Enter Product {Product.noOfProducts + 1} name ");
                    ProductName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"Enter Product {Product.noOfProducts + 1} price ");
                    Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    // Create a new Product object and add it to the List
                    Product newProduct = new Product(ProductName, Price);
                    products.Add(newProduct);

                    Console.WriteLine();

                    Console.WriteLine("Number of products in the inventory = " + Product.noOfProducts);

                    Console.WriteLine("Are there new products to be added to the inventory? [Y/N]");
                    select = Convert.ToChar(Console.ReadLine());
                    select = char.ToUpper(select);
                }
                Console.WriteLine();
                Console.WriteLine("All items added successfully");
                Console.WriteLine();

                Console.WriteLine("Do you wish to view details of all products? [Y/N]");
                select = Convert.ToChar(Console.ReadLine());
                select = char.ToUpper(select);

                if (select == 'Y')
                {
                    Console.WriteLine();
                    // Display details of all products
                    Console.WriteLine("Details of all products:");
                    foreach (Product product in products)
                    {
                        product.productDetails();
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for using our system");
                }

                

            }
            
            

            
        }
    }

    class Product
    {
        public string Productname;
        public double Price;
        public static int noOfProducts;
        public Product(string Productname, double Price)
        {
            this.Productname = Productname;
            this.Price = Price;
            noOfProducts++;
            Console.WriteLine("Item added successfully");
        }

        public void productDetails()
        {
            Console.WriteLine("Product name: " + Productname);
            Console.WriteLine("Product price: " + Price);
            Console.WriteLine();
        }
    }
}
