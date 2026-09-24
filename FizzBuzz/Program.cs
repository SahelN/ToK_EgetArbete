using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Error.WriteLine("Enter three integers separated by spaces: X Y N");
        Console.Error.WriteLine("  X = divisor for \"Fizz\"");
        Console.Error.WriteLine("  Y = divisor for \"Buzz\"");
        Console.Error.WriteLine("  N = count from 1 up to and including N");
        Console.Error.WriteLine("  Constraints: 1 <= X < Y <= N <= 100");
        Console.Error.WriteLine("Example: 2 3 7  >  ");
        var inputs = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(inputs))
        { 
            string[] parts = inputs.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 3)
            {
                Console.Error.WriteLine($"Error: expected 3 numbers but got {parts.Length}.");
                return;
            }
            if (!int.TryParse(parts[0], out int x) ||
                !int.TryParse(parts[1], out int y) ||
                !int.TryParse(parts[2], out int n))
            {
                Console.Error.WriteLine("Error: all three values must be whole numbers.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % x == 0)
                    Console.WriteLine("Fizz");
                else if (i % y == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}