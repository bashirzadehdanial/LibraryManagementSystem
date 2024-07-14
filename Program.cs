using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. List Books");
                Console.WriteLine("3. Checkout Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();
                        library.AddBook(title, author);
                        break;

                    case "2":
                        library.ListBooks();
                        break;

                    case "3":
                        Console.Write("Enter book ID to checkout: ");
                        if (int.TryParse(Console.ReadLine(), out int checkoutId))
                        {
                            library.CheckoutBook(checkoutId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter book ID to return: ");
                        if (int.TryParse(Console.ReadLine(), out int returnId))
                        {
                            library.ReturnBook(returnId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID.");
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
