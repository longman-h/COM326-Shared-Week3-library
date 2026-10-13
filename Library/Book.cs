using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;


        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
// Note: Example/demo Main has been removed from this class file to avoid
// multiple entry point errors. Keep library model types separate from
// application entry point. If you need a demo runner, create a separate
// Program.cs with a single Main method.
