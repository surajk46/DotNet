using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class Indexer
    {
        public int[] a=new int[10]; 

        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
    }

    class main4
    {
        static void Main(string[] args)
        {
            Indexer i=new Indexer();
            i.a[0] = 1;
            i.a[1] = 2;
            i.a[2] = 3;
            i.a[3] = 4;
            i.a[4] = 5;
            i.a[5] = 6;
            i.a[6] = 7;
            i.a[7] = 8;
            i.a[8] = 9;
            i.a[9] = 10;
          for(int j=0;j<10; j++)
            {
                Console.WriteLine(i.a[j]);
            }
        }
    }
}
