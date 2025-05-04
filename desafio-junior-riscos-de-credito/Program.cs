using desafio_junior_riscos_de_credito.business;

// Entrada de números exemplo
var entrada = new List<int> { 6, 4, 2, 3, 1, 5, 10, 7, 9, 8, 17, 15, 20, 21, 0 };

var primos = PrimeNumberIdentifier.FilterPrimes(entrada);

Console.WriteLine("Números primos: " + string.Join(", ", primos));