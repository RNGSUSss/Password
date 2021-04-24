using System;

namespace sobeklaewaisus
{
    class Program
    {
        static void Main(string[] args)
        {
            //6 
            Console.Write("in put word : ");
            char word = char.Parse(Console.ReadLine());
            Console.Write("in put stair width : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("in put stair height : ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("in put stair step : ");
            int step = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write(word);
                }
                Console.Write("\n");
                for (int l = 1; l <= height * step; l++)
                {
                    for (int j = 1; j <= width * step; j++)
                    {
                        Console.Write(word);
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadLine();





        }
    }
}
