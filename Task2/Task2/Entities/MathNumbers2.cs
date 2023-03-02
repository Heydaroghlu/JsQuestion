using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class MathNumbers2:BaseMath
    {
        private int[] _numbers;
        public MathNumbers2(int[] numbers)
        {
            _numbers = numbers;
            base.baseNumbers = _numbers;
        }
    }
}
