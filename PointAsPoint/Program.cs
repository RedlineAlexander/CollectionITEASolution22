using System;
using System.Collections.Generic;
using System.Collections;
namespace PointAsPoint
{
    struct Point
    {
        public Int32 x, y;
    }

    public sealed class Program
    {
       public static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Point p;
            for(Int32 i = 0; i < 10; i++)
            {
                p.x = p.y = i;
                a.Add(p);
                Console.WriteLine(p);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
