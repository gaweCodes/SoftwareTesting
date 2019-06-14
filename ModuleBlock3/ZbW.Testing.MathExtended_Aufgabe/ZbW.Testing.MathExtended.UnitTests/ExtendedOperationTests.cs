using NUnit.Framework;

namespace ZbW.Testing.MathExtended.Library.UnitTests
{
    [TestFixture]
    public class ExtendedOperationTests
    {
        [Test]
        public void Percent_Calculate_ReturnsResult()
        {
            // arrange
            var percent = new ExtendedOperation();

            // act
            var result = percent.Percent(50, 100);

            // assert
            Assert.That(result, Is.EqualTo(50));
        }
        [Test]
        public void Exponent_Calculate_ReturnsResult()
        {
            // arrange
            var exponent = new ExtendedOperation();

            // act
            var result = exponent.Exponent(10, 3);

            // assert
            Assert.That(result, Is.EqualTo(1000));
        }
        [Test]
        public void Factorial_Calculate_ReturnsResult()
        {
            // arrange
            var factorial = new ExtendedOperation();

            // act
            var result = factorial.Factorial(3);

            // assert
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void Modulo_Calculate_ReturnsResult()
        {
            // arrange
            var modulo = new ExtendedOperation();

            // act
            var result = modulo.Modulo(5, 3);

            // assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}