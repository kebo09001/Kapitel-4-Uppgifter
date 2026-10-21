using System;
using System.Diagnostics;
namespace Uppgift4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 31; i++)
            {
                Console.WriteLine(i);
            }
            int tal = 200;
            do
            {
                Console.WriteLine(tal);
                tal--;
            } while (tal > 179);
            tal = 1000;
            while (tal < 1401)
            {
                Console.WriteLine(tal);
                tal = tal + 50;
            }
        }
    }
}