using System;
namespace Uppgift5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal.");
            string tecken;
            int tal;
            string heltal = Console.ReadLine();
            string output = "";
            for (int i = 0; i<heltal.Length; i++)
            {
                tecken = heltal[i].ToString();
                tal = int.Parse(tecken);
                if(tal == 9)
                {
                    tal = 0;
                }
                else
                {
                    tal++;
                }
                output = output + tal;
            }
            Console.WriteLine(output);
        }
    }
}