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
            List<int> divisors = Enumerable.Range(1,root).ToList();
            /* Console.WriteLine(string.Join(", ", divisors)); */
            if(number <= 0){
                return false;
            }
            for(int index = 1; index < divisors.Count ; index ++ ){
                if(number % divisors[index] == 0){
                    /* Console.WriteLine("falso "+divisors[index]); */
                    return false;
                }
            }
            return true;
        }
    }
}