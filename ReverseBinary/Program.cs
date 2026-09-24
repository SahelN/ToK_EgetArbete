using System;

namespace ReverseBinary
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return;

            int number = int.Parse(input);
            Console.WriteLine(ReverseBits(number));
        }
        static int ReverseBits(int number)
        {
            var binary = Convert.ToString(number, 2);
            char[] chars = binary.ToCharArray();
            Array.Reverse(chars);
            var reversedBinary = new string(chars);
            return Convert.ToInt32(reversedBinary, 2);
        }
    }
}
