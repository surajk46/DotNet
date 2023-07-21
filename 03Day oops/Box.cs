using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day_oops
{
    internal class Box
    {
        int height { get; set; }
        int width { get; set; }
        int breadth { get; set; }
        public Box() { }
        public Box(int height, int width,int breadth)
        {
            this.height = height;   
            this.width = width;
            this.breadth = breadth;
        }

        public Box(Box box)
        {
            this.height = box.height;
            this.width = box.width;
            this.breadth = box.breadth;
        }
        public int calVolume()
        {
            return height*width*breadth;
        }
    }
}
