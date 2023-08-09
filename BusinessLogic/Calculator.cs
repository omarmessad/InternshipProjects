using System.Linq.Expressions;

namespace BusinessLogic
{
    public class Calculator
    {
        private decimal firstNumber;
        private decimal secondNumber;


        public static decimal AddNumbers(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static decimal SubNumbers(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static decimal MultiplyNumbers(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static decimal DivideNumbers(decimal firstNumber, decimal secondNumber)
        {
            if(secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNumber / secondNumber;
        }

        public static decimal ToThePowerOf(decimal firstNumber, decimal secondNumber)
        {
            decimal result = Convert.ToDecimal(Math.Pow(Decimal.ToDouble(firstNumber), Decimal.ToDouble(secondNumber)));
            return result;
        }

        public static decimal SquareRoot(decimal number)
        {
            decimal result = Convert.ToDecimal(Math.Sqrt(Decimal.ToDouble(number)));
            return result;
        }

    }
}