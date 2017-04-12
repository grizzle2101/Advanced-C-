using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expressions:");

            //Lambda Square Method
            //Args => expression, We Have a Lambda, we just need a Delegate to point to this new function.
            //Delegate <PassingInt, Expecting Return INT> to Lambda Calculation
            Func<int, int> square = number => number * number;

            Console.WriteLine(Square(5)); //Normal Method
            Console.WriteLine(square(5)); //Lambda Version

            //Lambda Referencing a Constant variable
            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            Console.WriteLine(multiplier(10));

            /*Lambdas in the Real World:
             * Say we want to Sort Books based on their price, or some other criteria.
             * We can Create a Method to return books < 10.
             * Or we can take advantage of .NET & Lambdas to do this is 1 line!
             */
             //Simple Way
            var books = new BookRepository().GetBooks();
            var cheapbooks = books.FindAll(IsChepaerThan10);

            foreach (var book in cheapbooks)
            {
                Console.WriteLine("Book {0} & Price {1}" , book.Title , book.Price);
            }

            //Lambda Way:
            Console.WriteLine("\nLambda Function to Filter Even Cheaper Books!");
            var evenCheaperbooks = books.FindAll(b => b.Price < 5);

            foreach (var book in evenCheaperbooks)
            {
                Console.WriteLine("Book {0} & Price {1}", book.Title, book.Price);
            }

            Console.ReadKey();
        }

        static bool IsChepaerThan10(Book book)
        {
            //Example of a Predicate Method, takes in an object and returns a True/False.
            return book.Price < 10;
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
