using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an error ocurred");
            }
        }

        static void CustomException()
        {
            var api = new YouTubeApi();
            var videos = api.GetVideos("filipe");
        }

        static void CalculatorError()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(5, 0);
        }

        static void StreamReaderError()
        {
            using (var streamReader = new StreamReader(@"c:\file.zip"))
            {
                var content = streamReader.ReadToEnd();
            }
        }
    }
}
