using System;

namespace final_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 3;
            int height = 3;
            int[,] block = new int[width,height];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    block[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(block[i,j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
