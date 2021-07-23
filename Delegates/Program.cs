using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += ApplyBackground;

            photoProcessor.Process("", filterHandler);
        }

        static void ApplyBackground(Photo photo)
        {
            Console.WriteLine("Apply Background");
        }
    }
}
