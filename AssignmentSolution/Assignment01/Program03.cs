using System;
namespace Assignment01
{
    internal class Program03
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter choice: 1. +, 2. -, 3. *, 4. /, 0. Exit");
                int i = int.Parse(Console.ReadLine());
                if (i==0) {
                    Environment.Exit(0);
                }
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
                        Console.WriteLine("Substraction: " + (f - s));
                        break;
                    case 3:
                        Console.WriteLine("Multipication: " + (f * s));
                        break;
                    case 4:
                        Console.WriteLine("Division: " + (f / s));
                        break;
                }
            }
            while (true);
        }
    }
}
