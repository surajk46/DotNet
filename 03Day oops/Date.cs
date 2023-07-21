using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class Date
    {
        int dd;
        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        int mm;
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        int yy;
        public int Yy
        {
            get { return yy; }
            set { yy = value;}
        }
        public Date()
        {
        }

        public Date(int dd,int mm,int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }
        public void ShowDate()
        {
            Console.WriteLine(dd+"-"+mm+"-"+yy);
        }
    }
}
