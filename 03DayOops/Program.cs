namespace _03DayOops
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Person p1 = new Person();
            //p1.Id = 1;
            //p1.Name = "sk";
            //p1.Display();
            int roll = int.Parse(Console.ReadLine());
            String name = Console.ReadLine();
            String email = Console.ReadLine();

            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            Student student = new Student(roll,name,email,m1,m2,m3);
            student.Display();
        }
    }
}