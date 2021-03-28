using System;

namespace sobeklaew
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            Console.Write("input number a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("input number b : ");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            do
            {
                if (x < y) { x = x + a; }
                else { y = y + b; }

            }
            while (x != y);
            Console.Write("X is {0}", x);
            Console.ReadLine();



        }
    }
}
