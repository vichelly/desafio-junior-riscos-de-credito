using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_junior_riscos_de_credito.Models
{
    public class PrimeNumber
    {
        public static bool PrimeCheck(int number){
            int root = (int)Math.Sqrt(number);
            List<int> range = Enumerable.Range(1,root).ToList();
            Console.WriteLine(string.Join(", ", range));
            return true;
        }
    }
}