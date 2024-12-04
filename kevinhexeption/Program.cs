
using System;

namespace exeptionKevinHattina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleMultipleExceptions("not a number", 1); // Skriv u Invalid format
            HandleMultipleExceptions("2", 5);           // Skriv ut Index out of range
            HandleMultipleExceptions("1", 1);           // Skriv ut 2
        }

        static void HandleMultipleExceptions(string input, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int parsedNumber = int.Parse(input);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
