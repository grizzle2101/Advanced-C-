using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction to Generics:");

           // 1.Creating a List
           // List numberList = new List();
           // numberList.Add(2);

           // 2.Trying to Add Book to List, Dosent work!
           //Book book = new Book() { ISBN = 1122, Title = "Programming with Mosh" };
           // numberList.Add(book);

           // 3.Solution, Create a Specific List Class for Books
           //BookList bookList = new BookList();
           //bookList.Add(book);

           // 4.What if we want to handle both INT's and Books?
           // ObjectList objList = new ObjectList();
           // objList.Add(book);
           // objList.Add(2);
           // /*The Problem with this approach, is the overhead required for boxing and unboxing objects or casting objects to fit our design
           //  *  we are paying a huge performance price for this inefficent Solution.
           //  * This is where Generics come into play, we can create a class that handles any data type passed to it at runtime, and not have this same issue.
           // */

           // 5.Generic List
           // ClassName<ObjectTypeToHandle>
           // GenericList<Book> genericList = new GenericList<Book>();
           // genericList.Add(book);

           // 6.Generic Dictionary
           //                                      <Key, Value>
           //var dictionary = new GenericDictionary<string, Book>();
           // dictionary.Add("1234", new Book() { ISBN = 1234, Title = "Troy" });
           // Console.ReadKey();

            //8. Testing Nullable Constraint
            var number = new Nullable<int>(2);
            Console.WriteLine("Has Value: {0} --- Value: {1}" , number.HasValue , number.GetValueOrDefault());

            //We Created our own strucutre to handle Null values, but this alredy exists in .Net Framework, see System.Nullable<>

            Console.ReadKey();
        }
    }


}
