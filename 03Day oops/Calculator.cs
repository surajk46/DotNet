using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class Calculator
    {
        int no1;
        int no2;

        public Calculator()
        {
        }

        public Calculator(int no1, int no2)
        {
            this.no1 = no1;
            this.no2 = no2;
        }

        public int Add() { 
            return no1+no2;
        }
        public int Sub()
        {
            int ans;
            if (no1 > no2)
                ans = no1 - no2;
            else
                ans = no2 - no1;
            return ans;
        }
        public int Mul()
        {
            return no1 * no2;
        }
        public float Div()
        {
            return (float)(no1 / no2);
        }
    }
}
