using Xunit;
using desafio_junior_riscos_de_credito.Models;
using System.Collections.Generic;

namespace desafio_junior_riscos_de_credito.Tests
{
    public class PrimeFilterTests
    {
        [Fact]
        public void FilterPrimes_ReturnsOnlyPrimes()
        {
            var input = new List<int> { 6, 4, 2, 3, 1, 5, 10, 7, 9, 8 };
            var expected = new List<int> { 1, 2, 3, 5, 7 };
            var result = PrimeFilter.FilterPrimes(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrimeCheck_ReturnsFalseForNegative()
        {
            bool result = PrimeNumber.PrimeCheck(-5);
            Assert.False(result);
        }

        [Fact]
        public void PrimeCheck_ReturnsTrueForPrimeNumber()
        {
            bool result = PrimeNumber.PrimeCheck(7);
            Assert.True(result);
        }
    }
}
