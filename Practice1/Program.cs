using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cows: ");
            int cows = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the number of sheeps: ");
            int sheeps = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the number of goats: ");
            int goats = int.Parse(Console.ReadLine() ?? "0");

            Farm farm = new(cows, sheeps, goats);
            farm.MakeNoise();
            farm.Info();
        }
    }
}
