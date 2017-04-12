using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction to LINQ - Language Intergrated Query:");

            //Retrive the Collection of Books
            var books = new BookRepository().GetBooks();

            //1. Retrive Books < 10 - The Old Fashioned Way.
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }

            //2. The LINQ Way - Need to Revise Extention Methods

            Console.ReadKey();
        }
    }
}
