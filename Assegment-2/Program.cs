using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assegment_2
{
    internal class Program
    {
        private static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        static void Main()
        {
            //questione 1
            string title = "clean code";
            string UpperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(UpperTitle);

            //questione 2
            string Title1 = "clean code";
            string Title2 = "clean code";

            Console.WriteLine(ReferenceEquals(Title1, Title2));


            //questione 3


            StringBuilder x = new StringBuilder();
            x.Append("book list");
            x.AppendLine("-Updated");

            Console.WriteLine(x.ToString());


            //questione 4


            x.Replace("book list", "library");
            Console.WriteLine(x.ToString());

            //questione 5


            string Title = "clean code";
            int pages = 464;
            Console.WriteLine("Book: " + Title + ", Pages: " + pages);

            //questione 6


            Console.WriteLine($"Book: {Title}, Pages: {pages}");


            //questione 7



            string.Format("Book: {0}, Pages: {1}", Title, pages);

            //questione 8

            int pages1 = 464;

            if (pages1 > 300)
            {
                Console.WriteLine(" long book");
            }
            else
            {
                Console.WriteLine("short book");
            }


            //questione 9

            bool isAvailable = true;
            if (pages1 > 300 && isAvailable)
            {
                Console.WriteLine("you can borrow this book");
            }
            else
            {
                Console.WriteLine("you cannot borrow this book");
            }

            //questione 10

            string bookTitle = "Refactoring";
            switch (bookTitle)
            {
                case "Clean Code":
                    Console.WriteLine("great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("nice pick!");
                    break;
                default:
                    Console.WriteLine("never heard of it");
                    break;

            }

            //questione 11

            string result = (pages1 > 300) ? "long book" : "short book";
            Console.WriteLine(result);

            //questione 12

            //            Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            //to print each book with its position number, like 1.Clean Code.


            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }

            //questione 13

            string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            int index = 0;
            while (index < book.Length)
            {
                Console.WriteLine($"{index + 1}. {book[index]}");
                index++;
            }


            //questione 14

            int num = 3;
            do
            {
                Console.WriteLine("Checking book...");
                break;
            } while (num >= 3);



            //questione 15
            string[] books1 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book1 in books1)
            {
                Console.WriteLine(book1);
            }

            //questione 16

            switch (bookTitle)
            {
                case "Clean Code":
                    Console.WriteLine("great choice!");
                    break;
                case "The Pragmatic Programmer":
                    Console.WriteLine("nice pick!");
                    break;
                case "Refactoring":
                    Console.WriteLine("good option!");
                    break;
                default:
                    Console.WriteLine("never heard of it");
                    break;
            }

            //questione 17
            //  Using the same books array, print every title except "The Pragmatic Programmer"(skip it with
            //continue, don't stop the loop).

            string[] books3 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string t in books3)
            {
                if (t == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(t);
            }

            //questione 18
            void printFirstBook()
            {
                if (book.Length == 0)
                    return;
                else
                {
                    Console.WriteLine(book[0]);
                }
            }

        }
    }
}
