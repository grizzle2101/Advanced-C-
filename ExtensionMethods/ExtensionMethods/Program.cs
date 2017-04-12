using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension Methods, Creating New Methods without Changing the Source Code!");


            string post = "This is supposed to be a very long blog post bla bla...";

            /*1. Say we want to create a feature that Shortens this long Text Blurb into something small.
            *   We can't inherit or Change the String class because we don't have its source code...
            *   Extension Methods to the Rescue!
            */
            var shortendPost = post.Shorten(5);
            Console.WriteLine(shortendPost);
            Console.ReadKey();
        }
    }

    //3. Static Class
    public static class StringExtensions
    {
        //New Extension Method to Give Strings new Functionality!
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number should be positive.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }

    //2.We Cannot Inherit from String as it is a Sealed Class
    //public class RichString : String
    //{
        
    //}
}
