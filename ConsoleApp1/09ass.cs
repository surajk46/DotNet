using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _09ass
    {
        static void Main9(string[] args)
        {
            Console.Write("Enter a number to chech palindrome or not :-");
            int num=int.Parse(Console.ReadLine());
            int num2 = num;
            int rem = 0;
            int rev = 0;
            while (num > 0)
            {
                rem =num % 10;
                rev=rev*10+rem;
                num /= 10;
            }
            if(rev==num2)
                Console.WriteLine(num2+" is Palindrome");
            else
                Console.WriteLine(num2+" is NOT palindrome");
        }
    }
}
