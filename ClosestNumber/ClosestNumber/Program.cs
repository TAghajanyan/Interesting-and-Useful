using System;
using System.Collections.Generic;
namespace ClosestNumber
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //Variant 1.

            //double[] nums = { 1.2, 1.5, 2.5, 2.8, 3, 3.9, 8, 10, 15, 20, 25 };
            //double num = Convert.ToDouble(Console.ReadLine());

            //double res = nums[0];
            //double min = Math.Abs(num - nums[0]);

            //for (int i = 1; nums[i++] < num && i < nums.Length;)
            //{
            //    if (Math.Abs(nums[i] - num) < min)
            //    {
            //        min = Math.Abs(nums[i] - num);
            //        res = nums[i];
            //    }
            //}

            //Console.WriteLine(res);
            //Console.ReadKey();
            
            // ----------------------------------------------------------------------


            //Variant 2.

            Closest closest = new Closest();
            bool b = false;

            Console.WriteLine("Input numbers. [e for exit!]");
            do
            {
                try
                {
                    closest.Input(Convert.ToDouble(Console.ReadLine()));
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
                closest.Input(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine($"Result: {closest.GetResult()}");
            }

            Console.ReadKey();
        }
    }
}

