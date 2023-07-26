using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06dayLINQ
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public int Age { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"{Id}  {Name}  {Language}   {Age}  {City}";
        }

    }
    internal class PersonLINQ
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student() { Id = 1,Name="Nikhil",Age=24,City="Pune",Language="C#"},
                new Student() { Id = 2,Name="Suraj",Age=23,City="Sangli",Language="Java"},
                new Student() { Id = 3,Name="Shrikant",Age=24,City="Nanded",Language="All"},
                new Student() { Id = 4,Name="Shivam",Age=26,City="Agra",Language="NA"},
                new Student() { Id = 5,Name="Rupesh",Age=24,City="Nashik",Language="AllHalfHalf"}
            };
            Console.WriteLine("city = pune");
            var arr1 = from a in list
                       where a.City.Equals("Pune")
                       select a;
             foreach ( var a in arr1 )
             {
                 Console.WriteLine(a);
             }

             var arr2 = (from a in list
                         select a.Age).Average();
            Console.WriteLine("Average age = "+arr2);

            Console.WriteLine("Name start with s");
            var arr3 = (from a in list
                        where a.Name.StartsWith("S")
                        select a);
            foreach( var a in arr3 )
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("First record");
            var arr4 = (from a in list
                        select a).First();
            Console.WriteLine(arr4);

            Console.WriteLine("last record");
            var arr5 = (from a in list
                        select a).Last();
            Console.WriteLine(arr5);

            Console.WriteLine("Assending sort");
            var arr6 = (from a in list
                        orderby a.Name
                        select a);
            foreach( var a in arr6 )
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Descending sort");
            var arr7 = (from a in list
                        orderby a.Name
                        select a);
            foreach (var a in arr7)
            {
                Console.WriteLine(a);
            }

            var arr8=(from a in list
                      select a.Age).Max();
            Console.WriteLine("Max age = "+arr8);

            var arr9=(from a in list
                      select a.Age).Min();
            Console.WriteLine("Min Age = "+arr9);


            var arr10 = (from a in list
                         group a by a.City);
            foreach( var a in arr10)
            {
                Console.WriteLine(a.);
                foreach(var item in a)
                {
                    Console.WriteLine(item);
                }
            }

            var arr11 = (from a in list
                         select a).Count();
            Console.WriteLine("Count of student = "+arr11);

            var arr12 = (from a in list
                         where a.City.Equals("Pune")
                         select a).Count();
            Console.WriteLine("Student number From Pune = "+arr12);
        }
        
    }
}
