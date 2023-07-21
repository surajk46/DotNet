using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class CalculDemo
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers :- ");
            int no1=int.Parse(Console.ReadLine());
            int no2 = int.Parse(Console.ReadLine());
            Calculator c = new Calculator(no1,no2);
            Console.WriteLine("Addition is : " + c.Add());
            Console.WriteLine("Substraction is : " + c.Sub());
            Console.WriteLine("Multiplication is : " + c.Mul());
            Console.WriteLine("Division is : " + c.Div());

        }
    }
}
