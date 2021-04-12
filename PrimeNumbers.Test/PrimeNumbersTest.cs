using System;
using Xunit;
using PrimeServices;

namespace PrimeNumbersTest
{
    public class PrimeNumbersTest
    {
        [Theory]
        [InlineData(0, -1)]
        [InlineData(1,2)]
        [InlineData(100, 541)]
        [InlineData(574, 4177)]
        [InlineData(1000, 7919)]

        public void GetPrime_WillReturnNthPrime(int nthPrime, int expectation)
        {
            int result = PrimeService.GetPrime(nthPrime);

            Assert.Equal(expectation, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]

        public void GetPrime_WillReturnNegative1ForNegativeInput(int nthPrime)
        {
            int result = PrimeService.GetPrime(nthPrime);

            Assert.Equal(-1, result);
        }
    }
}
