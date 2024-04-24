using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog120_S24_L7_NestedIfs_Arrays
{
    public class ArrayExample
    {

        public static double CalculateAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static void SortArray(int[] arr)
        {
            Array.Sort(arr); // Use Array.Sort for sorting
        }

        public static string[] ConvertListToArray(List<string> names)
        {
            return names.ToArray();
        }

        public static T GetRandomElement<T>(T[] items)
        {
            Random random = new Random();
            int randomIndex = random.Next(items.Length);
            return items[randomIndex];
        }

        public static int FindMaxValue(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

    }
}
