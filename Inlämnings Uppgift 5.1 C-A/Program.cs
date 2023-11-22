using System;
namespace Uppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta programm skriver ut några meningar.");
            string[] meningar = { "Jag tycker om att programmera.", "Detta är andra meningen i array:en.", "Jag är klar med uppgiften." };
            for (int i = 0; i < meningar.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(meningar[i]);
            }
            Console.ReadKey();
        }
    }
}