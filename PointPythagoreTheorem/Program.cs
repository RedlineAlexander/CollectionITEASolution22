using System;

namespace PointPythagoreTheorem
{
    internal struct Point : IComparable
    {
        private Int32 m_x, m_y;
        public Point(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
        }
       public Int32 CompareTo(Point other)
        {
            return Math.Sign(Math.Sqrt(m_x * m_x + m_y * m_y) - Math.Sqrt(other.m_x * other.m_x + other.m_y * other.m_y));
            throw new NotImplementedException();
        }
        public Int32 CompareTo(Object o)
        {
            if(GetType() != o.GetType())
            {
                throw new ArgumentException("o is not a Point");
            }
            return CompareTo((Point)o);
        }
    }
   public static class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10);
            Point p2 = new Point(20, 20);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.WriteLine(p1.GetType());
            Console.WriteLine(p1.CompareTo(p2));

            IComparable c = p1;
            Console.WriteLine(c.GetType());
            Console.WriteLine(p1.CompareTo(c));
            Console.WriteLine(c.CompareTo(p2));
            p2 = (Point)c;
            Console.WriteLine(p2.ToString());
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
