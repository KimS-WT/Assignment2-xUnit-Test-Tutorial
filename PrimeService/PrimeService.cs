using System;

namespace Prime.Services
{
    public class PrimeService
    {
        // Code Below From Tutorial
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /*To make all of the tests pass, update the IsPrime method (have done this twice now--for code below)
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }*/
    }
}