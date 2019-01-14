using System;

namespace BusinessLogic
{
    public class CalculatorService : ICalculatorService
    {
        public IApiResponse Add(decimal number1, decimal number2)
        {
            return _getResult(() => number1 + number2);
        } 

        public IApiResponse Substract(decimal number1, decimal number2)
        {
            return _getResult(() => number1 - number2);
        }

        public IApiResponse Multiply(decimal number1, decimal number2)
        {
            return _getResult(() => number1 * number2);
        }

        public IApiResponse Divide(decimal number1, decimal number2)
        {
            if (number2 != 0)
            {
                return _getResult(() => number1 / number2);
            }
            return new ErrorApiResponse(ErrorCode.DivisionByZero);
        }

        private IApiResponse _getResult(Func<decimal> func)
        {
            try
            {
                return new SuccessApiResponse(func());
            }
            catch (OverflowException)
            {
                return new ErrorApiResponse(ErrorCode.Overflow);
            }
            catch (Exception)
            {
                return new ErrorApiResponse(ErrorCode.Unknown);
            }
        }
    }
}