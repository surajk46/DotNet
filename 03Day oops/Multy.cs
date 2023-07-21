using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class Multy
    {
        public int Multyply(int a,int b=0,int c=1) {
            return a*b*c;
        }
        public void Multyply2( params int []a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
         }

    }
}
