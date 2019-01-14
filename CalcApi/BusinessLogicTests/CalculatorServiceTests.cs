using System;
using BusinessLogic;
using Shouldly;
using Xunit;

namespace BusinessLogicTests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var service = new CalculatorService();

            var result = service.Add(1.25M, 5.75M) as SuccessApiResponse;

            result.ShouldNotBeNull();
            result.Data.ShouldBe(7M);
        }

        [Fact]
        public void ShouldGiveBackOverflowMessageWhenAdding()
        {
            var service = new CalculatorService();

            var result = service.Add(Decimal.MaxValue, 5.75M) as ErrorApiResponse;

            result.ShouldNotBeNull();
            result.ErrorCode.ShouldBe(ErrorCode.Overflow);
        }

        [Fact]
        public void ShouldSubstract()
        {
            var service = new CalculatorService();

            var result = service.Substract(1.25M, 5.75M) as SuccessApiResponse;

            result.ShouldNotBeNull();
            result.Data.ShouldBe(-4.5M);
        }

        [Fact]
        public void ShouldGiveBackOverflowMessageWhenSubstracting()
        {
            var service = new CalculatorService();

            var result = service.Substract(Decimal.MinValue, 5.75M) as ErrorApiResponse;

            result.ShouldNotBeNull();
            result.ErrorCode.ShouldBe(ErrorCode.Overflow);
        }

        [Fact]
        public void ShouldMultiply()
        {
            var service = new CalculatorService();

            var result = service.Multiply(1.25M, 10M) as SuccessApiResponse;

            result.ShouldNotBeNull();
            result.Data.ShouldBe(12.5M);
        }

        [Fact]
        public void ShouldGiveBackOverflowMessageWhenMultiplying()
        {
            var service = new CalculatorService();

            var result = service.Multiply(Decimal.MinValue, 5.75M) as ErrorApiResponse;

            result.ShouldNotBeNull();
            result.ErrorCode.ShouldBe(ErrorCode.Overflow);
        }

        [Fact]
        public void ShouldDivide()
        {
            var service = new CalculatorService();

            var result = service.Divide(7M, 2M) as SuccessApiResponse;

            result.ShouldNotBeNull();
            result.Data.ShouldBe(3.5M);
        }

        [Fact]
        public void ShouldNotDivideByZero()
        {
            var service = new CalculatorService();

            var result = service.Divide(9M, 0M) as ErrorApiResponse;

            result.ShouldNotBeNull();
            result.ErrorCode.ShouldBe(ErrorCode.DivisionByZero);
        }
    }
}