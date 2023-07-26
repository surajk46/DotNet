using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class MyNumber
    {
        private int num;
        public MyNumber() {
            num = 0;
        }
        public MyNumber(int num)
        {
            this.num = num;
        }

        public bool isNegative() {
            return num < 0;
        }
        public bool isPositive()
        {
            return num > 0;
        }
        public bool isZero()
        {
            return num == 0;
        }
        public bool isPrime()
        {
            for (int i = 2; i <= num / 2; i++)
                if (num % i == 0)
                    return false;

            return true;
        }
        public bool isOdd()
        {
            return num %2!= 0;
        }
        public bool isEven()
        {
            return num %2== 0;
        }
    }

    class main3
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter a number:-");
            int num=int.Parse(Console.ReadLine());

            MyNumber myNumber = new MyNumber(num);
            if(myNumber.isNegative())
            {
                Console.WriteLine("negative number");
            }
            if (myNumber.isPositive())
            {
                Console.WriteLine("positive number");
            }
            if (myNumber.isPrime())
            {
                Console.WriteLine("prime number");
            }
            if (myNumber.isEven())
            {
                Console.WriteLine("even number");
            }
            if (myNumber.isOdd())
            {
                Console.WriteLine("odd number");
            }

        }
    }
}
