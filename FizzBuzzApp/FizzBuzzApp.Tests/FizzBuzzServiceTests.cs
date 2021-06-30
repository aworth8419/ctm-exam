using FizzBuzzApp.Api.Services;
using NUnit.Framework;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService FizzBuzzService;

        #region Setup
        [SetUp]
        public void Setup()
        {
            FizzBuzzService = new FizzBuzzService();
        }
        #endregion

        #region FizzBuzz_DivisibleBy3_Should_Succeed
        [Test]
        public void FizzBuzz_DivisibleBy3_Should_Succeed()
        {
            var result = FizzBuzzService.FizzBuzz(3);
            Assert.Contains("Fizz", result);
        }
        #endregion

        #region FizzBuzz_DivisibleBy5_Should_Succeed
        [Test]
        public void FizzBuzz_DivisibleBy5_Should_Succeed()
        {
            var result = FizzBuzzService.FizzBuzz(5);
            Assert.Contains("Buzz", result);
        }
        #endregion

        #region FizzBuzz_DivisibleBy3And5_Should_Succeed
        [Test]
        public void FizzBuzz_DivisibleBy3And5_Should_Succeed()
        {
            var result = FizzBuzzService.FizzBuzz(15);
            Assert.Contains("FizzBuzz", result);
        }
        #endregion
    }
}
