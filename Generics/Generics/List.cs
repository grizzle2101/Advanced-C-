using System;

namespace Generics
{
    //1. Simple List Data Structure
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    //2.The Problem is, for handleing new Objects, we need a new Class
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    //3. Creating an Object List to Handle Books & Ints
    public class ObjectList
    {
        public void Add(object value)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    //4. Generics to the Rescue: (Simple Generics)
    public class GenericList<T>
    {
        public void Add(T value)
        {
            
        }

        public T this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }
    //5. Generic Class with Multiple Parameters Eg Dictionary Data Structure:
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }
    }

    //6. Adding constraints to secure this Class!

    /*
     * Other Constraints, that we will go through in more details:
     * where T : ICompable
     * where T : Product
     * where T : Class
     * where T : New()
     */
}