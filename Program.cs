using System;

namespace _6._2
{
    class Program
    {
        //confirm
        static bool Confirm(string Cf)
        {
            char confirmWork;
            while (true)
            {
                Console.Write("{0} (Y/N) : ", Cf);
                confirmWork = char.Parse(Console.ReadLine());
                if (confirmWork == 'Y')
                {
                    return true;
                }
                else if (confirmWork == 'N')
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\"this program only help you to decide Because in the end the person who decides what to do is you.\"");
            Console.WriteLine("\"suit when past midnight maybe\"");
            if (Confirm("\"do you have a morning class?\""))
            {
                if (true)
                {
                    Console.Write("\"get to bed\"");
                }
            }
            else if (Confirm("\"do you have a exam tomorrow?\""))
            {
                if (true)
                {
                    Console.Write("\"get to bed\"");
                }
            }
            else if (Confirm("\"do you have a work to do?\""))
            {
                if (true)
                {
                    if (Confirm("\"did it close deadline yet?\""))
                    {
                        if (true)
                        {
                            Console.Write("\"get to work ai sus\"");
                        }
                    }
                    else { Console.Write("\"2 game no more\""); }
                }
            }
            else if (Confirm("\"tomorrow is week end right?\""))
            {
                if (true)
                {
                    Console.Write("\"yan shao ai here\"");
                }
            }
            else { Console.Write("\"play free but have some rest\""); }

            Console.ReadLine();
        }
    }
}
