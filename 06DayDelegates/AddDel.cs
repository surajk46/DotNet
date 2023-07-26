using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DayDelegates
{
    internal class AddDel
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public int Mul(int a,int b)
        {
            return (a * b) ;
        }
    }
    public delegate int AddDelegate(int a,int b);
    class MyClass2
    {
        static void Main4(string[] args)
        {
            AddDel addDel = new AddDel();
            AddDelegate addDelegate = new AddDelegate(addDel.Add);
            addDelegate += addDel.Sub;
            addDelegate+= addDel.Mul;
            Console.WriteLine( addDelegate(5, 10));


            Func<int, int, int> f = addDel.Mul;
            f += addDel.Sub;
            f += addDel.Add;
            Console.WriteLine( f(5, 10));
                

        }
    }
}
