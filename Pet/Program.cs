using System;
using System.Linq;

namespace Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bestIndex = 0;
            int bestScore = 0;

            for (int i = 0; i < 5; i++)
            {
                var inputs = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(inputs))
                {
                    string[] parts = inputs.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 4)
                    {
                        Console.Error.WriteLine($"Error: expected 4 numbers but got {parts.Length}.");
                        return;
                    }
                    var sum = parts.Select(int.Parse).Sum();
                    if (sum > bestScore)
                    {
                        bestIndex = i + 1;
                        bestScore = sum;
                    }
                }
            }

            Console.WriteLine(bestIndex + " " + bestScore);
        }
    }
}
