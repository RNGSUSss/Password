using System;

namespace sobeklaew
{
    class Program
    {
        static void Main(string[] args)
        {
            int buck1, buck2, buck3, allbuck;
            Console.Write("input bucket 1 : ");
            buck1 = int.Parse(Console.ReadLine());
            Console.Write("input bucket 2 : ");
            buck2 = int.Parse(Console.ReadLine());
            Console.Write("input bucket 3 : ");
            buck3 = int.Parse(Console.ReadLine());
            allbuck = buck1 + buck2 + buck3;

            while (allbuck > 0)
            {
                allbuck = buck1 + buck2 + buck3;
                Console.Write("buck1 = {0} , buck2 = {1} , buck3 = {2} ", buck1, buck2, buck3);
                int i = 0;
                i = i % 2;
                if (i == 0)
                {
                    Console.Write("A choose buck : ");
                    int numbox = int.Parse(Console.ReadLine());
                    switch (numbox)
                    {
                        case 1:
                            Console.Write("A pick out : ");
                            int pick = int.Parse(Console.ReadLine());
                            if (pick < 1 || pick > 2)
                            {
                                Console.Write("not in the rule");
                                buck1 = buck1 - pick;
                            }
                            else if (allbuck == 0)
                            {
                                Console.Write("A win");
                            }
                            else
                            {
                                buck1 = buck1 - pick;
                                i++;
                            }
                            break;
                        case 2:
                            Console.Write("A pick out : ");
                            pick = int.Parse(Console.ReadLine());
                            if (pick < 1 || pick > 2)
                            {
                                Console.Write("not in the rule");
                                buck2 = buck2 - pick;
                            }
                            else if (allbuck == 0)
                            {
                                Console.Write("A win");
                            }
                            else
                            {
                                buck2 = buck2 - pick;
                                i++;
                            }
                            break;
                        case 3:
                            Console.Write("A pick out : ");
                            pick = int.Parse(Console.ReadLine());
                            if (pick < 1 || pick > 2)
                            {
                                Console.Write("not in the rule");
                                buck3 = buck3 - pick;
                            }
                            else if (allbuck == 0)
                            {
                                Console.Write("A win");
                            }
                            else
                            {
                                buck3 = buck3 - pick;
                                i++;
                            }
                            break;
                    }
                    Console.Write("B choose buck : ");
                    numbox = int.Parse(Console.ReadLine());
                    switch (numbox)
                    {
                        case 1:
                            Console.Write("B pick out : ");
                            int pick = int.Parse(Console.ReadLine());
                            if (pick < 1 || pick > 2)
                            {
                                Console.Write("not in the rule");
                                buck1 = buck1 - pick;
                            }
                            else if (allbuck == 0)
                            {
                                Console.Write("B win");
                            }
                            else
                            {
                                buck1 = buck1 - pick;
                                i++;
                            }
                            break;
                        case 2:
                            Console.Write("B pick out : ");
                            pick = int.Parse(Console.ReadLine());
                            if (pick < 1 || pick > 2)
                            {
                                Console.Write("not in the rule");
                                buck2 = buck2 - pick;
                            }
                            else if (allbuck == 0)
                            {
                                Console.Write("B win");
                            }
                            else
                            {
                                buck2 = buck2 - pick;
                                i++;
                            }
                            break;
                        case 3:
                            Console.Write("A pick out : ");
                            pick = int.Parse(Console.ReadLine());
                            if (pick < 1 || pick > 2)
                            {
                                Console.Write("not in the rule");
                                buck3 = buck3 - pick;
                            }
                            else if (allbuck == 0)
                            {
                                Console.Write("A win");
                            }
                            else
                            {
                                buck3 = buck3 - pick;
                                i++;
                            }
                            break;
                    }
                }


            }
            Console.ReadLine();



        }
    }
}
