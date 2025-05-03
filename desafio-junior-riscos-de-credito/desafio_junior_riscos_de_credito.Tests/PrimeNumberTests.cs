using Xunit;
using desafio_junior_riscos_de_credito.Models;

namespace desafio_junior_riscos_de_credito.Tests
{
    public class PrimeNumberTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(9, false)]
        [InlineData(11, true)]
        [InlineData(0, false)]
        [InlineData(-3, false)]
        public void PrimeCheck_ReturnsCorrectResult(int number, bool expected)
        {
            bool result = PrimeNumber.PrimeCheck(number);
            Assert.Equal(expected, result);
        }
    }
}
