using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a)	Create an instance of the "Product" class, representing a product with an ID of 101, name "Laptop," price $800, and quantity in stock 10.
            Product product = new Product(101, "Laptop", 800, 10);

            // b)	Access and display the name, price, and quantity of the product.
            Console.WriteLine();
            Console.WriteLine("Product Name " + product.productName);
            Console.WriteLine("Product Price " + product.price);
            Console.WriteLine("Product Quantity Available " + product.quantityInStock);

            // c)	Attempt to modify the product's ID from external code (outside the class). Observe and comment on the result.
            Console.WriteLine();
            // product.productId = 105;
            // Error stating productId not in the context of class Product. This is because productId is a private variable.

            product.BuyProduct("Laptop", 2);

        }
    }

    class Product
    {
        private int productId;
        public string productName;
        public double price;
        public int quantityInStock;



        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public int getProductId()
        {
            return productId;
        }

        public void AddProduct(string productName, int amountOfProducts)
        {
            if (amountOfProducts < 0 )
            {
                Console.WriteLine("Amount of products should be more than zero");
            }
            else
            {
                quantityInStock += amountOfProducts;
                Console.WriteLine($"Added {amountOfProducts} units of {productName} to the inventory.");
                Console.WriteLine("Currently inventory has " + quantityInStock + " units of " + productName);
            }
        }

        public void BuyProduct(string productName, int amountOfProducts)
        {
            double totalPrice;
            if (amountOfProducts < 0)
            {
                Console.WriteLine("Amount of products needed to be purchased should be more than zero");
            }
            else if (amountOfProducts > quantityInStock)
            {
                Console.WriteLine($"Cannot purchase this amount. Only {quantityInStock} {productName} are in stock");
            }
            else
            {
                Console.WriteLine("Price of 1 " + productName + " is Rs. " + price);
                totalPrice = price * amountOfProducts;
                Console.WriteLine("Amount to be paid Rs. " + totalPrice );
                Console.WriteLine($"Bought {amountOfProducts} units of {productName} from the store.");
                quantityInStock -= amountOfProducts;
                Console.WriteLine("Currently inventory has " + quantityInStock + " units of " + productName);
            }
        }
    }
}
