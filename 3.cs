using System;

namespace sobeklaewaisus
{
    class Program
    {
        static void Main(string[] args)
        {


            //3
            Console.Write("in put mode :");
            string mode = (Console.ReadLine());
            Console.Write("in put filmBackWidth :");
            float filmBackWidth = float.Parse(Console.ReadLine());
            if (mode == "flength")
            {
                double fov;
                Console.Write("in put flength :");
                float flength = float.Parse(Console.ReadLine());
                if (flength > 0)
                {
                    fov = 2 * Math.Atan(filmBackWidth / 2 * flength);
                    Console.Write("flength = {0} , fov = {1}", flength, fov);
                }
                else { Console.Write("invalid flength please in put again"); }
            }
            else if (mode == "fov")
            {
                double flength;
                Console.Write("in put fov :");
                float fov = float.Parse(Console.ReadLine());
                if (fov > 0.1 && fov < 6.28)
                {
                    flength = filmBackWidth / (2 * Math.Tan(fov / 2));
                    Console.Write("flength = {0} , fov = {1}", flength, fov);
                }
                else { Console.Write("invalid fov please in put again"); }
            }

            Console.ReadLine();

           
        }
    }
}
