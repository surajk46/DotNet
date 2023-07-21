using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class AddOverload
    {
        int a,b,c,d;

        public AddOverload(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public AddOverload(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int add(int a, int b) 
        {
            return a + b; 
        }
        public int add(int a, int b,int c)
        {
            return a + b+c;
        }
        public int add(int a, int b, int c,int d)
        {
            return a + b + c+d;
        }




    }
    class main1
    {
        static void Main1(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            AddOverload addOverload = new AddOverload(h,b,w,x);
            Console.WriteLine( addOverload.add(b, h));
            Console.WriteLine(addOverload.add(b, w, h)) ;
        }
    }
}
