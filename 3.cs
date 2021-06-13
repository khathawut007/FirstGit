using System;

namespace sob
{
    class Program
    {
        static void Main()
        {
            Random num = new Random();
            int[] number = new int[10];

            for(int a = 0; a < number.Length; a++)
            {
                number[a] = num.Next(1, 101);
            }

            Console.WriteLine("Number: ");
            foreach(var numbers in number)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            GetMaxAndMin(number);

            Console.ReadLine();
        }

        static void GetMaxAndMin(int[] op)
        {
            int max = op[0];
            int min = op[0];

            foreach (var number in op)
            {
                if(number > max)
                {
                    Console.WriteLine(max);
                }
                if (number > min)
                {
                    Console.WriteLine(min);
                }
            }
            Console.ReadLine();
        }
    }
    
}
