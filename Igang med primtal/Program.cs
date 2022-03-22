using System;

namespace Igang_med_primtal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("While loop\n");
            while (i <100)
            {
                if (i < 50)
                {
                    Console.WriteLine(i);
                    

                }
                i++;

            }
            Console.WriteLine("\nFor Loop \n");
            for (int j = 100; j > 0; j--)
            {
                Console.WriteLine(j);
            }
        }
    }
}
