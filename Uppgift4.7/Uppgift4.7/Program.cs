using System;
namespace Uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett sträng");
            string sträng = Console.ReadLine();
            Console.WriteLine("Skriv in ett sträng med EXAKT två tecken.");
            string tvåtecken = Console.ReadLine();
            int stämmer = 0;
            for (int i = 0; i < sträng.Length; i++)
            {
                if (tvåtecken[0] == sträng[i])
                {
                    stämmer++;
                    break;
                }
            }
            for (int i = 0; i < sträng.Length; i++)
            {
                if (tvåtecken[1] == sträng[i])
                {
                    stämmer++;
                    break;
                }
            }
            if (stämmer == 2)
            {
                Console.WriteLine($"Både av tecknet {tvåtecken[0]} och {tvåtecken[1]} finns på strängen {sträng}");
            }
            else
            {
                Console.WriteLine($"Tyvärr så finns det bara en eller inga tecken på {sträng}.");
            }
        }
    }
}