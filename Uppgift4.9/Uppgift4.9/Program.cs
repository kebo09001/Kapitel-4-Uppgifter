using System;
namespace Uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int AntalX = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int AntalO = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-mönster per rad?");
            int antalOMönster = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int rader = int.Parse(Console.ReadLine());
            string XGrupp = "";
            for (int i = 0; i < AntalX;  i++)
            {
                XGrupp += "X";
            }
            string OGrupp = "";
            for (int i = 0; i < AntalO; i++)
            {
                OGrupp += "O";
            }
            string enRad = XGrupp;
            for(int i = 0; i < antalOMönster; i++)
            {
                enRad += "-" + OGrupp + "-" + XGrupp;
            }
            for (int i = 0; i < rader; i++)
            {
                Console.WriteLine(enRad);
            }
        }
    }
}