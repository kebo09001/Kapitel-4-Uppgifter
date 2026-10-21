using System;
namespace Uppgift4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar; 
            double tal1;
            double tal2;
            do
            {
                Console.WriteLine("Välj ett av följande alternativ.");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                Console.WriteLine("");
                svar = Console.ReadLine();
                switch (svar)
                {
                    case "1":
                        Console.WriteLine("Skriv det första talet.");
                        tal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv det andra talet.");
                        tal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Talet blir {tal1 - tal2}");
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("Skriv det första talet.");
                        tal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv det andra talet.");
                        tal2 = double.Parse(Console.ReadLine());
                        if (tal2 == 0)
                        {
                            Console.WriteLine("Talet får inte delas med noll. Ta ett annat tal.");
                        }
                        else
                        {
                            Console.WriteLine($"Talet blir {tal1 / tal2}");
                            Console.WriteLine("");
                        }
                        break;
                }
                
            } while (svar != "3");
        }
    }
}