using System;
using ConsoleApplication1._1_Multiples_Of_3_And_5;
using Euler;
using NUnit.Framework.Constraints;

namespace ConsoleApplication1
{
    static class EulerPogram
    {

        private static void Main(string[] args)
        {
            while (true)
            {
                Start();
            }
        }

        private static void Start()
        {
            Console.WriteLine("Select a Problem");
            var problem = Console.ReadLine();

            switch (problem)
            {
                case "1":
                    Problem1();
                    break;
                case "3":
                    Problem3();
                    break;
                default :
                    Start();
                    break;
            }
        }

        public static void Problem1()
        {
            int input;
            Console.Write("Please Enter A number");
            var evaluator = new ThreeFiveEvaluator();

            if (int.TryParse(Console.ReadLine(), out input))
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
        

        public static void Problem3()
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
