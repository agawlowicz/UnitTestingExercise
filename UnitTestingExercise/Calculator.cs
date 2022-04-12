using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        public int Add(int num1, int num2, int num3)
            => num1 + num2 + num3;

        public int Subtract(int minuend, int subtrahend)
            => minuend - subtrahend;

        public int Multiply(int x, int y)
            => x * y;

        //Assumption y != 0
        public int Divide(int x, int y)
            => x / y;
    }
}
