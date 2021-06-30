using FizzBuzzApp.Api.Controllers;
using FizzBuzzApp.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzControllerTests
    {
        private FizzBuzzController FizzBuzzController;

        #region Setup
        [SetUp]
        public void Setup()
        {
            FizzBuzzController = new FizzBuzzController(new Mock<ILogger<FizzBuzzController>>().Object, new FizzBuzzService());
        }
        #endregion

        #region Get_LessThan1_Should_Fail
        [Test]
        public void Get_LessThan1_Should_Fail()
        {
            var result = FizzBuzzController.Get(0);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }
        #endregion

        #region Get_GreaterThan100_Should_Fail
        [Test]
        public void Get_GreaterThan100_Should_Fail()
        {
            var result = FizzBuzzController.Get(101);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }
        #endregion

        #region Get_Between1And100_Should_Succeed
        [Test]
        public void Get_Between1And100_Should_Succeed()
        {
            var result = FizzBuzzController.Get(1);
            Assert.IsInstanceOf<OkObjectResult>(result);

            result = FizzBuzzController.Get(50);
            Assert.IsInstanceOf<OkObjectResult>(result);

            result = FizzBuzzController.Get(100);
            Assert.IsInstanceOf<OkObjectResult>(result);
        }
        #endregion
    }
}