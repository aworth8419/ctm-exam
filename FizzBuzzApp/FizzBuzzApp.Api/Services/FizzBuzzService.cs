using System.Collections.Generic;

namespace FizzBuzzApp.Api.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        #region FizzBuzz
        /// <summary>
        /// Converts integer input to list of FizzBuzz strings
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> FizzBuzz(int n)
        {
            bool isDivisibleBy3 = false;
            bool isDivisibleBy5 = false;

            var lst = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                isDivisibleBy3 = i % 3 == 0;
                isDivisibleBy5 = i % 5 == 0;

                if(isDivisibleBy3 && isDivisibleBy5)
                {
                    lst.Add("FizzBuzz");
                }
                else if(isDivisibleBy3)
                {
                    lst.Add("Fizz");
                }
                else if(isDivisibleBy5)
                {
                    lst.Add("Buzz");
                }
                else
                {
                    lst.Add(i.ToString());
                }
            }

            return lst;
        }
        #endregion
    }
}
