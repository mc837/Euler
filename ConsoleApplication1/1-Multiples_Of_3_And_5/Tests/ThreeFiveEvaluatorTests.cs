using NUnit.Framework;

namespace ConsoleApplication1._1_Multiples_Of_3_And_5.Tests
{
    class ThreeFiveEvaluatorTests
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        //The sum of these multiples is 23.

        [Test]
        public void Should_Return23AsAddedMultiplesOfThreeAndFive_When_TheNumber10IsSelectedAsTheMaximumNumber()
        {
            var evaluator = new ThreeFiveEvaluator();
            var result = evaluator.Evaluate(10);
            Assert.That(result, Is.EqualTo(23));
        }
    }
}
