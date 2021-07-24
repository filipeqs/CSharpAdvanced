using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Linq Query Operator
            var cheaperBooks = from b in books
                               where b.Price > 10
                               orderby b.Price
                               select b;

            // Linq Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => new { Title = b.Title });

            // Single throws an Error if nothing is found, Single or Default returns null
            var mvcBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            var firstBook = books.First(b => b.Title == "C# Advanced Topics");

            var bookPagination = books.Skip(2).Take(3);

            var count = books.Count();

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);

            Console.WriteLine("Single: " + mvcBook.Title);
            Console.WriteLine("First: " + firstBook.Title);

            Console.WriteLine("Books Pagination:");
            foreach (var book in bookPagination)
                Console.WriteLine(book.Title);

            Console.WriteLine("Chep Books ordered:");
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title);
        }
    }
}
