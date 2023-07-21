using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _10ass
    {
        static void Main10(string[] args)
        {
            String[] a = { "Shiv", "Shivam", "Shrikant", "Rupesh", "Shiv", "Shivam" };
            String [] b=new string[a.Length];
            int k = 0;
            b[k++] = a[0];

            for(int i=1; i<a.Length; i++)
            {
                Boolean flag = false;
                int j = 0;
                for(j=0; j < b.Length;j++ )
                {
                    if (a[i].Equals(b[j]))
                    {
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    b[k++] = a[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
