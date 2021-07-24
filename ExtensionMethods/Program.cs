using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = "this is supposed to be very long blog post bla bla bla";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }
}
