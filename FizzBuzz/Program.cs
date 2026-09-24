using System;
public class Program
{
    private static void Main()
    {
        Console.Error.WriteLine("Enter three integers separated by spaces: X Y N");
        Console.Error.WriteLine("  X = divisor for \"Fizz\"");
        Console.Error.WriteLine("  Y = divisor for \"Buzz\"");
        Console.Error.WriteLine("  N = count from 1 up to and including N");
        Console.Error.WriteLine("  Constraints: 1 <= X < Y <= N <= 100");
        Console.Error.WriteLine("Example: 2 3 7");

        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.Error.WriteLine("Error: no input.");
            return;
        }

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
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

        if (!AreValidConstraints(x, y, n))
        {
            Console.Error.WriteLine("Error: values must satisfy 1 <= X < Y <= N <= 100.");
            return;
        }

        for (var i = 1; i <= n; i++)
        {
            Console.WriteLine(FizzBuzzValue(i, x, y));
        }
    }
    public static bool AreValidConstraints(int x, int y, int n)
    {
        return x >= 1 && x < y && y <= n && n <= 100;
    }
    public static string FizzBuzzValue(int i, int x, int y)
    {
        var fizz = i % x == 0;
        var buzz = i % y == 0;

        if (fizz && buzz) return "FizzBuzz";
        if (fizz) return "Fizz";
        if (buzz) return "Buzz";
        return i.ToString();
    }
}