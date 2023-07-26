using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06dayLINQ
{
    internal class ListString
    {
        static void Main1(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Priya");
            list.Add("Prachi");
            list.Add("Shivani");
            list.Add("Ravina");
            list.Add("Rasika");
            list.Add("Smita");

            var arr1=(from a in list
                     select a).Count();
            Console.WriteLine("Count = "+arr1);

            var arr2 = (from a in list
                        where a.Length>=4
                        select a).Count();
            Console.WriteLine("Element having length >4 = "+arr2);


            var arr3 = (from a in list
                        where a.Length >= 3 && a.Length <= 6
                        select a).Count();
            Console.WriteLine("length bet 3 and 6 = "+arr3);
            Console.WriteLine("*********** assending sort **************");
            var arr4 = from a in list
                       orderby a
                       select a;
            foreach(var a in arr4)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("*********** descending sort **************");
            var arr5 = from a in list
                       orderby a descending
                       select a;
            foreach (var a in arr5)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("********** contains s **********");
            var arr7 = from a in list
                       where a.StartsWith("S")
                       select a;
            foreach(var a in arr7)
            {
                Console.WriteLine(a);
            }
        }
    }
}
