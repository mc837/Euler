using System;

namespace ConsoleApplication1
{
    class PrimeFactorEvaluator
    {
        public int Evaluate(double i)
        {
            double highestFactor = 0;
            for (var count = 2; count < i; count++)
            {
                double result = i / count;
                if (IsInteger(result))
                {
                    if (isPrime(result) && result > highestFactor)
                    {
                        highestFactor = result;
                    }
                }
            }
            return (int)highestFactor;
        }

        public static bool isPrime(double number)
        {
            int boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static bool IsInteger(double number)
        {
            return (number % 1 == 0);
        }
    }
}
