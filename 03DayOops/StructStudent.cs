using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DayOops
{
    struct Student
    {
        public int Roll { get; set; }
        public String Name { get; set; }
        public string email { get;set; }

        public int m1;
        public int m2 { get; set; }
        public int m3 { get; set; }

        public Student(int roll, string name, string email, int m1, int m2, int m3)
        {
            Roll = roll;
            Name = name;
            this.email = email;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void Display()
        {
            Console.WriteLine($"{Roll}---{Name}--{m1}----{m2}");
        }

    }
}
