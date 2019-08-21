using System;

namespace ClosestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Closest my = new Closest();
            bool b = false;

            Console.WriteLine("Input numbers. [e for exit!]");
            do
            {
                try
                {
                    my.Input(Convert.ToDouble(Console.ReadLine()));
                    b = true;
                }
                catch (FormatException)
                {
                    break;
                }

            } while (true);

            if (b)
            {
                Console.WriteLine("Input your number.");
                my.Input(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine($"Result: {my.GetResult()}");
            }

            Console.ReadKey();
        }
    }
}

