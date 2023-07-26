using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DayDelegates
{
    internal class Predicate
    {
        public Boolean isPositive(int n)
        {
            return n > 0;
        }
        public Boolean isNegative(int n)
        {
            return !isPositive(n);
        }

        public Boolean isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public bool isPerfect(int n)
        {
            int sum = 0;
            bool flag = false;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n)
                flag = true;
            return flag;
        }

        public bool isPalindrome(int n)
        {
            int n2 = n;
            bool flag = false;
            int rem = 0, rev = 0 ;
            while(n2 > 0)
            {
                rem = n2 % 10;
                rev = rev * 10 + rem;
                n2 /= 10;
            }
            if (rev == n)
                flag = true;
            return flag;
        }
        
    }
    class Myclass3
    {
        static void Main(string[] args)
        {
            Predicate pre = new Predicate();
            Predicate<int> d = pre.isPositive;
            Predicate<int> e = pre.isNegative;
           // d += pre.isNegative;
            
            Console.WriteLine(d(22));
        }
    }

}
