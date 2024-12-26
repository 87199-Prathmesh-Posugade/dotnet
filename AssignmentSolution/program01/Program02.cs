using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice: 1. +, 2. -, 3. *, 4. /");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Number");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            float s = float.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("Addition: " + (f + s));
                    break;
                case 2:
                    Console.WriteLine("Subtraction: " + (f - s));
                    break;
                case 3:
                    Console.WriteLine("Multiplication: " + (f * s));
                    break;
                case 4:
                    if (s != 0)
                    {
                        Console.WriteLine("Division: " + (f / s));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
