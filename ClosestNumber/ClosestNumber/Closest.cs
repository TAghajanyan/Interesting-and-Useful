using System;
using System.Collections.Generic;

namespace ClosestNumber
{
    class Closest
    {
        private List<double> numbers = new List<double>();
        private int index;

        public void Input(double number)
        {
            numbers.Add(number);
        }

        public double GetResult()
        {
            double current = numbers[numbers.Count - 1];
            numbers.Sort();
            index = numbers.IndexOf(current);

            if (index == 0)
            {
                return numbers[index + 1];
            }
            else if (index == numbers.Count - 1)
            {
                return numbers[index - 1];
            }
            else if (Math.Abs(numbers[index] - numbers[index - 1]) < Math.Abs(numbers[index] - numbers[index + 1]))
            {
                return numbers[index - 1];
            }
            else
            {
                return numbers[index + 1];
            }
        }
    }
}

