using BusinessLogic;
using CalcApi.Controllers;
using NSubstitute;
using Xunit;
using Shouldly;

namespace CalcApiTests
{
    public class CalcControllerTest
    {
        [Fact]
        public void ShouldReturnCalculatedAddition()
        {
            var calculatorService = Substitute.For<ICalculatorService>();
            var calculationResult = new SuccessApiResponse(3M);
            calculatorService.Add(1M, 2M).Returns(calculationResult);
            var controller = new CalcController(calculatorService);

            var result = controller.Add(1M, 2M);

            result.Value.ShouldBe(calculationResult);
        }

        [Fact]
        public void ShouldReturnCalculatedSubstraction()
        {
            var calculatorService = Substitute.For<ICalculatorService>();
            var calculationResult = new SuccessApiResponse(3M);
            calculatorService.Substract(1M, 2M).Returns(calculationResult);
            var controller = new CalcController(calculatorService);

            var result = controller.Substract(1M, 2M);

            result.Value.ShouldBe(calculationResult);
        }

        [Fact]
        public void ShouldReturnCalculatedMultiplication()
        {
            var calculatorService = Substitute.For<ICalculatorService>();
            var calculationResult = new SuccessApiResponse(3M);
            calculatorService.Multiply(1M, 2M).Returns(calculationResult);
            var controller = new CalcController(calculatorService);

            var result = controller.Multiply(1M, 2M);

            result.Value.ShouldBe(calculationResult);
        }

        [Fact]
        public void ShouldReturnCalculatedDivision()
        {
            var calculatorService = Substitute.For<ICalculatorService>();
            var calculationResult = new SuccessApiResponse(3M);
            calculatorService.Divide(1M, 2M).Returns(calculationResult);
            var controller = new CalcController(calculatorService);

            var result = controller.Divide(1M, 2M);

            result.Value.ShouldBe(calculationResult);
        }
    }
}