using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Photo Processing Framework with Delegates:");

            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();

            //Creating Pointers to our Filters
            //PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += filter.Resize;
            filterHandler += RemoveRedEye; //Pointing to Method in this Class.

            //Sending Photo, and List of New Methods to Use!
            processor.Process("Test123.jpg", filterHandler);


            Console.ReadKey();
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing Red Eye.");
        }
    }
}
