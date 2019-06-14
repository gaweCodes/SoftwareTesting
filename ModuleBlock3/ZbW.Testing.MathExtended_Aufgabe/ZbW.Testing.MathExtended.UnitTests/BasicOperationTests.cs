using NUnit.Framework;

namespace ZbW.Testing.MathExtended.Library.UnitTests
{
    [TestFixture]
    public class BasicOperationTests
    {
        [Test]
        public void Addition_Calculate_ReturnsSum()
        {
            // Arrange
            var additionOperation = new BasicOperation();

            // Act
            var result = additionOperation.Addition(5, 6);

            // Assert
            Assert.That(result, Is.EqualTo(11));
        }
        [Test]
        public  void Subtraction_Calculate_ReturnsDifference()
        {
            // Arrange
            var subtractOperation = new BasicOperation();

            // Act
            var result = subtractOperation.Subtraction(5, 6);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void Division_Calculate_ReturnsQuotient()
        {
            // Arrange
            var divisionOperation = new BasicOperation();

            // Act
            var result = divisionOperation.Division(12, 6);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Division_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var divisionOperation = new BasicOperation();

            // act
            void Calculation() => divisionOperation.Division(100, 0);

            // Act and Assert
            Assert.Throws<ZeroDivisorNotAllowedException>(Calculation, "The exception doesn't occur.");
        }
        [Test]
        public void Multiplication_Calculate_ReturnsProduct()
        {
            // Arrange
            var multiplicationOperation = new BasicOperation();

            // Act
            var result = multiplicationOperation.Multiplication(6, 6);

            // Assert
            Assert.That(result, Is.EqualTo(36));
        }
    }
}