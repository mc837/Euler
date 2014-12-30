using System;
using Euler;

namespace ConsoleApplication1
{
    static class Three_LargestPrimeFactorPogram
    {

        private static void Main(string[] args)
        {
            double input;
            Console.Write("Please Enter A number");
            var evaluator = new PrimeFactorEvaluator();

            if (double.TryParse(Console.ReadLine(), out input))
            {
                var result = evaluator.Evaluate(input);
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else
            {
                Console.Write("Only Numbers !!!");
                Console.ReadKey();
            }
        }
    }
}
