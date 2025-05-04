using System;
using System.Reflection;
using Xunit;
using desafio_junior_riscos_de_credito.business;

namespace desafio_junior_riscos_de_credito.Tests
{
    public class PrimeNumberIdentifierTests
    {
        // Testa o método IsPrime utilizando reflexão
        [Theory]
        [InlineData(1, true)]  // Aqui 1 será considerado primo conforme seu critério
        [InlineData(2, true)]  // 2 é primo
        [InlineData(3, true)]  // 3 é primo
        [InlineData(4, false)] // 4 não é primo
        [InlineData(5, true)]  // 5 é primo
        [InlineData(9, false)] // 9 não é primo
        public void TestIsPrime(int number, bool expectedResult)
        {
            // Usando reflexão para acessar o método IsPrime privado
            var methodInfo = typeof(PrimeNumberIdentifier)
                                .GetMethod("IsPrime", BindingFlags.NonPublic | BindingFlags.Static);

            // Invocando o método privado
            var result = methodInfo.Invoke(null, new object[] { number });

            // Verificando o resultado
            Assert.Equal(expectedResult, result);
        }
    }
}
