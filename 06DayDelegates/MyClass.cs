using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DayDelegates
{

    internal class MyClass
    {
       
        void display(string s)
        {
            Console.WriteLine(s);
        }
        void Upper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        void Lower(string s)
        {
            Console.WriteLine(s.ToLower());
        }
        public delegate void mydel(string s);
        static void Main2(string[] args)
        {
            MyClass myClass = new MyClass();
            mydel d = new mydel(myClass.display);
            d += myClass.Upper;
            d+= myClass.Lower;
            d("Suraj");

            Action<String> del = myClass.display;
            del += myClass.Lower;
            del += myClass.Upper;



            //Func<string> f=myClass.display;   //no  running errr
            //f += myClass.Lower;
            //f+= myClass.Upper;
            del += delegate (string s)
            {
                Console.WriteLine("Hello " + s);
            };
            del +=  (s)=>{ Console.WriteLine(s.Length); };
             del("Shivam");
        }
    }
}
