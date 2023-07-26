using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DayOops
{
    struct Book
    {
        public int ID;
        public string Name;
        public string Author;
        public float Price;

        public void Display()
        {
            Console.WriteLine($"{ID}--{Name}--{Author}--{Price}");
        }
    }
    class main2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter book id = ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter book name = ");
            string name = Console.ReadLine();
            Console.Write("Enter book author = ");
            string author = Console.ReadLine();
            Console.Write("Enter book price = ");
            float price = int.Parse(Console.ReadLine());
            Book book = new Book()
            {
                ID = id,
                Name=name,
                Author=author,
                Price=price
            };
            book.Display();
            Console.WriteLine();
        }
       
    }
}
