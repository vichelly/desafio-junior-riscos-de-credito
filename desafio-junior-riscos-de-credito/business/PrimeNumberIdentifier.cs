namespace desafio_junior_riscos_de_credito.business
{
    public class PrimeNumberIdentifier
    {
        private static bool IsPrime(int number){
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

        public static List<int> FilterPrimes(List<int> numbers)
        {
            return numbers
                .Where(n => IsPrime(n))
                .Order()
                .ToList();
        }
    }
}