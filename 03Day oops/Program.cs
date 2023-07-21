namespace _03Day_oops
{
    internal class Program
    {
        static void Main1(string[] args)
        {
         
            int h=int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Box box = new Box(h,w,b);
            Console.Write("Volume of 1 "+ box.calVolume());
            
            Console.WriteLine();

            Box box2 = new Box(box);
            Console.Write("Volume of 2 " + box2.calVolume());


        }
    }
}