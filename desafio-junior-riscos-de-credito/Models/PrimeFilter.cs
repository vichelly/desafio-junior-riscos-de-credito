using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio_junior_riscos_de_credito.Models
{
    public class PrimeFilter
    {
        public static List<int> FilterPrimes(List<int> numbers)
        {
            return numbers
                .Where(n => PrimeNumber.PrimeCheck(n))
                .Order()
                .ToList();
        }
    }
}
