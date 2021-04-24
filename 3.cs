using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[]args)
        {
            float x, y, dx, dy, step;
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            int i = int.Parse(Console.ReadLine());

            if (dx >= dy)
            {
                step = (dx);
            }
            else
            {
                step = (dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                i = 1;
                
            }
            if (i <= step)
            {
                Console.Write("{0}{1}",x,y);
                x += dx;
                y += dy;
                i++;
            }
            else
            {
                Console.ReadLine();
            }
        }
        
    }
}
