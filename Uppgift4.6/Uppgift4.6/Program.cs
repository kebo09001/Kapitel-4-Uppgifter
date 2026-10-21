using System;
namespace Uppgift4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande som ska skrivas ut vertikalt.");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hur många steg åt höger ska den veritkala meddelandet flyttas?");
            int moves = int.Parse(Console.ReadLine());
            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < moves; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}