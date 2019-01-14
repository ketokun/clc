namespace BusinessLogic
{
    public interface ICalculatorService
    {
        IApiResponse Add(decimal number1, decimal number2);
        IApiResponse Substract(decimal number1, decimal number2);
        IApiResponse Multiply(decimal number1, decimal number2);
        IApiResponse Divide(decimal number1, decimal number2);
    }
}