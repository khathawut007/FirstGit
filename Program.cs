using System;

namespace ใหม่
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            switch (mode)
            {
                case "time":
                    Console.WriteLine("{0}  {1}",x, Math.Pow(y - 1, 2));
                    break;
                case "price":
                    Console.WriteLine("{0}  {1}",Math.Pow(x - 1, 2),y);
                    break;
                default:
                    Console.WriteLine("Invalid mode");
                    break;

            }
            if (x < 0)
            Console.WriteLine("Invalid mouse position");
            
            Console.ReadLine();


        }
    }
}
