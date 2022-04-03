using System;
using System.Collections.Generic;
namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
             SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
             SortedSet<int> b = new SortedSet<int>() { 9, 3, 5, 7, 6, 1 };

            //PrintCollection(a);
            //PrintCollection(b); 

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }

    }
}