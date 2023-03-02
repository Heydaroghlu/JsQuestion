using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class MathNumbers4:BaseMath
    {
        //Eslinde 3 cu class ilede 4 cu taski yazmaq olardi.
        private int[] _numbers;
        public MathNumbers4()
        {
            _numbers = new int[] { 5, 6, 7, 8, 9, 10 };
            base.baseNumbers = _numbers;
        }
        public MathNumbers4(int number)
        {
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                numbers[i] = i;
            }
            base.baseNumbers = numbers;
        }
        public MathNumbers4(int[] numbers)
        {
            base.baseNumbers = numbers;
        }
    }
}
