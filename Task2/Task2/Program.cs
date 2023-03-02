using System;
using Task2.Entities;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------TASK 1-------");
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            MathNumbers numbers = new MathNumbers();
            numbers.numbers = nums;
            Console.WriteLine("First task's count: "+numbers.CountOfOddNumbers()+" and sum:"+numbers.SumOfOddNumbers());


            Console.WriteLine("-----------TASK 2-------");
            MathNumbers2 numbers2 = new MathNumbers2(nums);
            Console.WriteLine("Second task's result: "+numbers2.CountOfOddNumbers() + " and sum:" + numbers.SumOfOddNumbers());


            Console.WriteLine("-----------Task3--------");
            MathNumbers3 numbersCtorFirst = new MathNumbers3();
            Console.WriteLine("First Ctor's count: "+numbersCtorFirst.CountOfOddNumbers() + " and sum:" + numbersCtorFirst.SumOfOddNumbers());
            MathNumbers3 numbersCtorSecond = new MathNumbers3(3);
            Console.WriteLine("Second Ctor's count: " + numbersCtorSecond.CountOfOddNumbers() + " and sum:" + numbersCtorSecond.SumOfOddNumbers());
            MathNumbers3 numbersCtorThrid = new MathNumbers3(nums);
            Console.WriteLine("First Ctor's count: " + numbersCtorThrid.CountOfOddNumbers() + " and sum:" + numbersCtorThrid.SumOfOddNumbers());



            Console.WriteLine("----------Task4---------");
            MathNumbers4[] mathNumbers4Array = new MathNumbers4[3];
            MathNumbers4 numbers4CtorFirst = new MathNumbers4();
            MathNumbers4 numbers4CtorSecond = new MathNumbers4(3);
            MathNumbers4 numbers4CtorThrid = new MathNumbers4(nums);
            mathNumbers4Array[0] = numbers4CtorFirst;
            mathNumbers4Array[1] = numbers4CtorSecond;
            mathNumbers4Array[2] = numbers4CtorThrid;
            for (int i = 0; i < mathNumbers4Array.Length; i++)
            { 
                Console.WriteLine($"{i+1}.Sum: "+mathNumbers4Array[i].SumOfOddNumbers()+" Count: " +mathNumbers4Array[i].CountOfOddNumbers());
            }

        }
    }
}
