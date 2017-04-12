using System;

namespace Generics
{
    public class Utilities<T> where T : IComparable, new() //Must be of Icompareable & Have a default Constructor!
    {
        //Compare & Return the bigger Number.
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        //Performing the Same Function, but using Generic Input
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
            //return a > b ? a : b;
            //Cannot Apply Operation, as the compiler dosen't know what type T is going to be, Adding ICompareable Constraint
        }
        //9. Adding Constraint
        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}