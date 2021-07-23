using System;

namespace LambdaExpressions
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // () => ...
            // x => ...
            // (x, y, z) => ...
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title);
        }
    }
}
