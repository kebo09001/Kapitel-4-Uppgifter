using System;
namespace Uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm triangelns sidolängd.");
            int sidolängd = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sidolängd; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}