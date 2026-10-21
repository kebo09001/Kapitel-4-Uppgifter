using System;
namespace Uppgifter4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal.");
            string svar = Console.ReadLine();
            int tal = int.Parse(svar);
            do
            {
                Console.WriteLine("Vill du skriva en till heltal? J/N");
                svar = Console.ReadLine();
                if (svar.ToLower() == "j")
                {
                    Console.WriteLine("Skriv in ett heltal.");
                    svar = Console.ReadLine();
                    if(int.Parse(svar) > tal)
                    {
                        tal = int.Parse(svar);
                    }
                }
            } while (svar.ToLower() != "n");

            Console.WriteLine($"Det största talet du har angett var {tal}");
            
        }
    }
}