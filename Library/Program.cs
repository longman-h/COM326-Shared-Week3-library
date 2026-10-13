using System;
using System.Collections.Generic;
using Library;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            List<Member> members = new List<Member>();

            books.Add(new Book { Title = "C# for beginners", Author = "BillGates", ISBN = "12345678" });
            books.Add(new Book { Title = "C# Methods and classes", Author = "Microsoft", ISBN = "55667778" });

            members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
            members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

            // Display all books and members
            foreach (var book in books)
            {
                book.DisplayInfo();
            }

            foreach (var member in members)
            {
                member.DisplayInfo();
            }

            // Create a dictionary to track book inventory by ISBN
            Dictionary<string, int> bookInventory = new Dictionary<string, int>();


            // Add our two sample books to the inventory (ISBN, Quantity)
            bookInventory.Add("1234567", 5);
            bookInventory.Add("2233445", 2);


            // Display the inventory for a specific book using its ISBN key
            Console.WriteLine($"Copies of 'C# for beginners' in stock: {bookInventory["1234567"]}");

            Console.WriteLine("Checking inventory for a missing book...");

            try
            {
                // This ISBN does not exist, so it will throw a KeyNotFoundException
                Console.WriteLine(bookInventory["9999999"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: That ISBN was not found in the inventory system.");
            }
            finally
            {
                Console.WriteLine("Inventory check complete.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
