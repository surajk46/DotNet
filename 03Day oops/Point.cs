using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine($"[{x},{y}]");
        }
    }

    class main
    {
        static void Main1(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Point p = new Point(x,y);
            p.Display();

            Point p2 = new Point { x = 44, y = 0 };
            p2.Display();

        }
    }
}
