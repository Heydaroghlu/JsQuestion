using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class BaseMath: IBaseMath
    {
        protected int[] baseNumbers;
        
        public int SumOfOddNumbers()
        {
            int sum = 0;
            for (int i = 0; i < baseNumbers.Length; i++)
            {
                if (baseNumbers[i] % 2 == 1)
                {
                    sum += baseNumbers[i];
                }
            }
            return sum;
        }
        public int CountOfOddNumbers()
        {
            int counter = 0;
            for (int i = 0; i < baseNumbers.Length; i++)
            {
                if (baseNumbers[i] % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
