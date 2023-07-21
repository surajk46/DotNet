using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _11
    {
        static void Main(string[] args)
        {
            int[] arr = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + " ");
                arr[i] = int.Parse(args[i]);
            }
            Console.WriteLine();
            /*
             int sum = 0;
             int k = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 //k= int.Parse(args[i]);
                 sum += arr[i];
             }
             Console.WriteLine("Sum = " + sum);

             // int max = arr[0];
             int max = int.Parse(args[0]);
             int min = int.Parse(args[0]);
             for (int i = 0; i < args.Length; i++)
             {
                 if (max < int.Parse(args[i]))
                     max = int.Parse(args[i]);
                 if (min > int.Parse(args[i]))
                     min = int.Parse(args[i]);
             }
             Console.WriteLine("min = " + min);
             Console.WriteLine("max = " + max);

             for (int i = 0; i < args.Length; i++)
             {
                 k = int.Parse(args[i]);
                 sum = 0;
                 for (int j = 1; j < k; j++)
                 {
                     if (k % j == 0)
                         sum += j;
                 }
                 if (sum == k)
                     Console.WriteLine(k + " perfect no ");
             }

             for (int i = 0; i < args.Length; i++)
             {
                 k = int.Parse(args[i]);
                 Boolean flag = true;
                 for (int j = 2; j <= k / 2; j++)
                 {
                     if (k % j == 0)
                     {
                         flag = false;
                         break;
                     }
                 }
                 if (flag)
                     Console.WriteLine(k + " is Prime No");
             }
            

            Boolean[] visited = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if ((arr[i] == arr[j]) && (visited[j]==false))
                    {
                        count++;
                        visited[j] = true;
                       // arr[j] = null;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine(arr[i] + " occurs " + count + " times");
                }
            }
            */

            /*
               int max = int.Parse(args[0]);
               int max2 = max;
               int  min = int.Parse(args[0]);
               int min2=min;
               if (arr[0] < arr[1])
                   min = arr[1];
               else
                   max= arr[1];
               for (int i = 0; i < args.Length; i++)
               {

                   if (max < int.Parse(args[i]))
                       {
                               max2=max;
                               max = int.Parse(args[i]);
                       }
                   if (min > int.Parse(args[i]))
                       {
                           min2=min;
                           min = int.Parse(args[i]);
                       }
               }
               Console.WriteLine(" second min = " + min2);
               Console.WriteLine("second max = " + max2);

               */
            /*
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[i+j];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            */
            int mid = arr.Length/2 ;
            for(int i=0; i < mid; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length-i-1];
                arr[arr.Length-i-1] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
