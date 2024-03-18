using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers) sum += number;
            return sum;
        }

        public static void IncreamentNoRef(int number)
        {
            number++;
        }

        public static void Increament(ref int number)
        {
            number++;
        }
    }
}
