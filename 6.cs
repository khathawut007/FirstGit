using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int row = 1; row <= b; row++)
            {
                for (int column = 1; column <= b; column++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
        static void Horizontal(int x,int z)
        {
            for(int row =1; row <= x; row++)
            {
                for (int column = 1; column <= z; column++)
                {
                    
                }
                Console.WriteLine();
            }
        }
       
        
    }
}
