using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _04ass
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter Marks in Maths:- ");
            int maths=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks in Chemistry :- ");
            int chem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks in physics :- ");
            int phy = int.Parse(Console.ReadLine());

            String eli= "Not Eligible";
            int total = maths + chem + phy;
            if (maths >= 65 && phy >= 55 && chem >= 50 & total >= 180)
                eli = "Eligible";
            Console.WriteLine("you are "+eli+" for cource");

        }
    }
}
