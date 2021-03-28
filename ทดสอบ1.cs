using System;

namespace ทดสอบ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;
            if (x = y)
            {
                while (x < y)
                {
                    x = x + a;
                }
                y = y + b;
            }
            else
            {
                Console.WriteLine(x);
            }
            

        }
    }
}
