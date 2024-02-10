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
            Book book1 = new Book("Goosebumps", "R.L Stine");
            Book book2 = new Book("Harry Potter", "J.K. Rowling");

            Console.WriteLine("Detils of book 1");
            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);

            Console.WriteLine("Detils of book 2");
            Console.WriteLine(book2.Title);
            Console.WriteLine(book2.Author);


        }
    }

    class Book
    {
        public string Title;
        public string Author;

        public Book(string Title , string Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
}
