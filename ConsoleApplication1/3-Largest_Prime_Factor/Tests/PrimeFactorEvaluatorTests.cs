using ConsoleApplication1;
using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class PrimeFactorEvaluatorTests
    {
        private PrimeFactorEvaluator _evaluator;

        [SetUp]
        public void SetUp()
        {
            _evaluator = new PrimeFactorEvaluator();
        }

        [Test]
        public void Should_Return5_When_25IsSelected()
        {
            var result = _evaluator.Evaluate(25);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Should_ReturnAListContaining2And5_When_50IsSelected()
        {
            var result = _evaluator.Evaluate(50);
            Assert.That(result, Is.EqualTo(5));

        }

        [Test]
        public void Should_Return5_7_13_29_When_13195IsSelected()
        {
            var result = _evaluator.Evaluate(13195);
            Assert.That(result, Is.EqualTo(29));
        }
    }
}
