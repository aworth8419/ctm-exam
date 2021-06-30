using System.Collections.Generic;

namespace FizzBuzzApp.Api.Services
{
    public interface IFizzBuzzService
    {
        List<string> FizzBuzz(int n);
    }
}
