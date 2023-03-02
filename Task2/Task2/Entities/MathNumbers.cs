using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class MathNumbers: IBaseMath
    {
        public int[] numbers;
        public int SumOfOddNumbers()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }
        public int CountOfOddNumbers()
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
