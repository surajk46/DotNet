using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06dayLINQ
{
    internal class Arr
    {
        static void Main1(string[] args)
        {
            int[] ar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var arr1 = from s in ar
            //           where s > 5
            //           select s;

            //foreach (var s in arr1)
            //{
            //    Console.WriteLine(s);
            //}



            var cnt=(from s in ar
                     select s).Count();
            Console.WriteLine("Count = "+cnt);
            Console.WriteLine();

            

            Console.WriteLine("between 3 and 6");
            var arr2= from s in ar
                      where s >=3 && s <=6
                      select s;
            foreach( var s in arr2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Sort assending ");
            var arr3 = from s in ar
                       orderby s
                       select s;
            foreach( var s in arr3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("descending sory");
            var arr4 = from s in ar
                       orderby s descending
                       select s;
            foreach(var s in arr4)
            {
                Console.WriteLine(s);
            }
        }
    }
}
