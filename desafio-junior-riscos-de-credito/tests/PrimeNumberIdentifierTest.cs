using desafio_junior_riscos_de_credito.business;
using Xunit;
using System.Collections.Generic;

namespace desafio_junior_riscos_de_credito.Tests
{
    public class PrimeNumberIdentifierTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(9, false)]
        [InlineData(13, true)]
        [InlineData(0, false)]
        [InlineData(-3, false)]
        public void IsPrime_IdentifiesCorrectly(int number, bool expected)
        {
            var result = InvokeIsPrime(number);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FilterPrimes_FiltersCorrectly()
        {
            var input = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = new List<int> { 1, 2, 3, 5, 7 }; // 1 incluso conforme regra do desafio
            var result = PrimeNumberIdentifier.FilterPrimes(input);
            Assert.Equal(expected, result);
        }

        private bool InvokeIsPrime(int number)
        {
            // Usando reflexão porque IsPrime é private. Você pode mudar para public se quiser.
            var method = typeof(PrimeNumberIdentifier).GetMethod("IsPrime", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            return (bool)method.Invoke(null, new object[] { number });
        }
    }
}
