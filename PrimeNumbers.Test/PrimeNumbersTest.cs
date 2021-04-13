using System;
using Xunit;
using PrimeServices;

namespace PrimeNumbersTest
{
    public class PrimeNumbersTest
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(100, 541)]
        [InlineData(574, 4177)]
        [InlineData(1000, 7919)]

        public void GetPrime_WillReturnNthPrime(int nthPrime, int expectation)
        {
            int result = PrimeService.GetPrime(nthPrime);

            Assert.Equal(expectation, result);
        }
    }
}
