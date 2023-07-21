using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class _01
    {
        static void Main1(string[] args)
        {
            /*
            Multy m=new Multy();
            Console.WriteLine(m.Multyply(5, 5, 5));
            Console.WriteLine(m.Multyply(5, 5));
            Console.WriteLine(m.Multyply(a:10, c:100));
            m.Multyply2(1,5,9);
            */
            Date d = new Date(4, 6, 2000);
            Date d2 = new Date();
            d.ShowDate();
            d2.ShowDate();

            Date d3 = new Date() { Dd = 1, Mm = 1, Yy = 2000 };
            d3.ShowDate();
        }
    }
}
