using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class MathNumbers3:BaseMath
    {
        private int[] _numbers;
        public MathNumbers3()
        {
            _numbers = new int[] {5,6,7,8,9,10};
            base.baseNumbers = _numbers;
        }
        public MathNumbers3(int number)
        {
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                numbers[i] = i;
            }
            base.baseNumbers = numbers;
        }
        public MathNumbers3(int[] numbers)
        {
            base.baseNumbers = numbers;
        }
       
    }
}
