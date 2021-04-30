using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1;
            Console.Write("in put your number : ");
            double number = double.Parse(Console.ReadLine());
            if (number < 0) { Console.Write("Invalid Pascal's triangle row number"); }

            for (int i = 0; i <= number; i++) //line
            {
                for (int j = 0; j <= i; j++) //row
                {
                    if (i == 0 || j == 0) { num = 1; } //number
                    else num = num * (i - j + 1) / j;
                    Console.Write("{0} ",num);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
