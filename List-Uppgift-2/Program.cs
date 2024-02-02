using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nummerLista = new();
            string input = " ";

            Console.WriteLine("Skriv in ett antal nummer på nya rader, skriv en tom rad när du är nöjd.");

            while (input != "")
            {
                    input = Console.ReadLine();
                switch (input)
                {
                    case "":
                        break;
                    default:
                        Console.WriteLine();
                        Console.Write("Skriv in nummer:");
                        nummerLista.Add(int.Parse(input));
                        break;
                }
            }
            Max(nummerLista);
        }

        static void Max(List<int> nummerLista)
        {
            nummerLista.Sort();
            Console.WriteLine(nummerLista[nummerLista.Count() - 1]);
        }
    }
}