using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2014, 1, 1); ;
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;


            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue(): " + date.HasValue);
        }
    }
}
