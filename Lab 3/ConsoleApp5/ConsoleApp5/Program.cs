using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            char mainSelect;

            // Create an array or list of LibraryBook objects
            LibraryBook[] bookListArray = new LibraryBook[]
            {
            new LibraryBook("Harry Potter", "J.K Rowling", true),
            new LibraryBook("Goosebumps", "R.L Stein", true),
            new LibraryBook("Sherlock Holmes", "Arthur Conan Doyle", true),
            new LibraryBook("Treasure Island", "Robert Louis", true),
            new LibraryBook("Adventures Of Tom Swayer", "Mark Twain", true)
            };

            Console.WriteLine("Welcome to our liabrary! ");
            

            do
            {
                Console.WriteLine("What brings you to our liabrary today?");
                Console.WriteLine("Enter number of the option");
                Console.WriteLine("1. Show all books");
                Console.WriteLine("2. Borrow book");
                Console.WriteLine("3. Return book");
                Console.WriteLine();
                select = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (select)
                {
                    case 1:
                        {
                            LibraryBook.DisplayBookList(bookListArray);
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Which book do you wish to borrow?");
                            Console.WriteLine("Enter the number of the book you wish to borrow");

                            LibraryBook.DisplayBookList(bookListArray);

                            int selectedBookIndex = Convert.ToInt32(Console.ReadLine());

                            // Ensure the input is within the valid range
                            if (selectedBookIndex >= 1 && selectedBookIndex <= bookListArray.Length)
                            {
                                Console.WriteLine($"You want to borrow {bookListArray[selectedBookIndex-1].Title} by {bookListArray[selectedBookIndex - 1].Author}");
                                // Now you can work with the selectedBook
                                
                                Console.WriteLine();
                                Console.WriteLine("Checking if book available");
                                bookListArray[selectedBookIndex - 1].checkAvailability(bookListArray);
                                
                            }
                            else
                            {
                                Console.WriteLine("Invalid book number. Please enter a valid number.");
                            }

                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Which book's availablity do you wish to check?");
                            Console.WriteLine("Enter the number of the book you wish to check");

                            LibraryBook.DisplayBookList(bookListArray);

                            int selectedBookIndex = Convert.ToInt32(Console.ReadLine());

                            // Ensure the input is within the valid range
                            if (selectedBookIndex >= 1 && selectedBookIndex <= bookListArray.Length)
                            {
                                Console.WriteLine($"You want to check availability of {bookListArray[selectedBookIndex - 1].Title} by {bookListArray[selectedBookIndex - 1].Author}");
                                // Now you can work with the selectedBook

                                Console.WriteLine();
                                bookListArray[selectedBookIndex - 1].checkAvailability(bookListArray);

                            }
                            else
                            {
                                Console.WriteLine("Invalid book number. Please enter a valid number.");
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Incorrect selection");
                        }
                        break;

                }

                Console.WriteLine("Do you have any other services needed from the liabrary? [Y/N]");
                mainSelect = Convert.ToChar(Console.ReadLine());
                mainSelect = char.ToUpper(mainSelect);


            } while (mainSelect == 'Y');

            Console.WriteLine("Thank you for using our liabrary");
            Console.WriteLine("Have a nice day");
            
        }
    }

    class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;

        public LibraryBook(string Title, string Author, bool Available)
        {
            this.Title = Title;
            this.Author = Author;
            this.Available = Available;
        }

        public void BorrowBook()
        {
            Available = false;
            Console.WriteLine("You have borrowed " + Title + " written by " + Author);
            Console.WriteLine();
        }

        public void returnBook()
        {
            Available = true;
            Console.WriteLine("Thank you for returning the " + Title + " written by " + Author);
            Console.WriteLine();
        }

        public void checkAvailability(LibraryBook[] bookList)
        {
            char select; 
            if (Available == false)
            {
                Console.WriteLine($"Sorry {Title} is not available");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is available");

                Console.WriteLine("Do you wish to borrow the book? [Y/N]");
                select = Convert.ToChar(Console.ReadLine());
                select = char.ToUpper(select);

                if (select == 'Y')
                {
                    BorrowBook();
                }
                
            }
        }

        public static void DisplayBookList(LibraryBook[] bookList)
        {
            Console.WriteLine("Book List:");

            for (int i = 0; i < bookList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Book: {bookList[i].Title} by {bookList[i].Author}");
            }
        }
    }
}
