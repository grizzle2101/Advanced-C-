using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Book //Book Object for List
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public class BookRepository
    {
        //Generic List, taking objects of Type Book.
        public List<Book> GetBooks()
        {
            return new List<Book>
            { //Object Initalizer Syntax to Quickly Create the Books we need.
                new Book() {Title = "Title 1", Price = 5.50},
                new Book() {Title = "Title 2", Price = 6.20},
                new Book() {Title = "Title 3", Price = 17.50},
                new Book() {Title = "Title 4", Price = 4.50}
            };

        }
    }
}
