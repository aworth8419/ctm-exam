using FizzBuzzApp.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace FizzBuzzApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        #region + Properties

        private readonly ILogger<FizzBuzzController> _logger;
        private readonly IFizzBuzzService _fizzBuzzService;

        #endregion

        #region + Constructors

        public FizzBuzzController(ILogger<FizzBuzzController> logger, IFizzBuzzService fizzBuzzService)
        {
            _logger = logger;
            _fizzBuzzService = fizzBuzzService;
        }

        #endregion

        #region + Public Methods

        #region Get
        /// <summary>
        /// Converts integer input to list of FizzBuzz strings
        /// </summary>
        /// <param name="n">Integer between 1 and 100</param>
        /// <returns></returns>
        [HttpGet("{n}")]        
        public IActionResult Get(int n)
        {
            try
            {
                if (n < 1 || n > 100)
                    return BadRequest("Number must be between 1 and 100");

                var result = _fizzBuzzService.FizzBuzz(n);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError($"{ex}");
            }

            return BadRequest("Something went wrong");
        }
        #endregion

        #endregion
    }
}
