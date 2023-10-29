using System;
using System.Net.Http.Headers;

namespace inlamning4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många 'x' vill du ha per grupp?");
            int xPerGroup = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Hur många 'o' vill du ha per grupp?");
            int oPerGroup = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Hur många 'o' grupper vill du ha?");
            int oGroupAmount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Hur många rader av ditt mönster vill du ska skrivas ut?");
            int lineAmount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < lineAmount; i++)
            {
                for (int x = 0; x < oGroupAmount + 1; x++)
                {
                    for (int y = 0; y < xPerGroup; y++)
                    {
                        Console.Write("X");

                    }

                    if (x < oGroupAmount)
                    {
                        Console.Write("-");
                        for (int z = 0; z < oPerGroup; z++)
                        {
                            Console.Write("O");

                        }
                        Console.Write("-");
                    }
                


                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }

    }

}
