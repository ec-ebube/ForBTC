using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForBTC
{
    public class Sort
    {
        public static void forsorting()
        {
            int[] numbers = { 2, 10, 28, 7, 3, 19, 0 };
            int x = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        x = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = x;
                    }
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}