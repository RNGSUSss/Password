using System;

namespace sobeklaewaisus
{
    class Program
    {
        static void Main(string[] args)
        {
            //4
            float x, y, dx, dy, step;
            Console.Write("in put x1 : ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("in put y1 : ");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("in put x2 : ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("in put y2 : ");
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                for (int i = 1; i <= step; i++)
                {
                    Console.Write("{0}, {1}", x, y);
                    x += dx;
                    y += dy;
                }
            }
            else
            {
                step = Math.Abs(dy);
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                for (int i = 1; i <= step; i++)
                {
                    Console.Write("{0}, {1}", x, y);
                    x += dx;
                    y += dy;
                }
            }
            Console.ReadLine();






        }
    }
}
