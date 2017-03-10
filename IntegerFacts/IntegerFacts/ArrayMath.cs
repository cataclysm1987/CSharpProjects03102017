using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFacts
{
    public static class ArrayMath
    {
        public static void GetMath(int[] array, out int min, out int max, out int sum, out int average)
        {
            sum = 0;
            min = array.Min();
            max = array.Max();
            foreach (int value in array)
            {
                sum += value;
            }
            average = sum / 20;
        }
    }
}
