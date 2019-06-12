using NUnit.Framework;

namespace ZbW.Testing.MathExtended.Library.UnitTests
{
    [TestFixture]
    public class BasicOperationTests
    {
        [Test]
        public void Addition_Calculate_Correct()
        {
            // Arrange
            var additionOperation = new BasicOperation();

            // Act
            var result = additionOperation.Addition(5, 6);

            // Assert
            Assert.That(result, Is.EqualTo(11));
        }
        [Test]
        public  void Subtraction_Calculate_Correct()
        {
            // Arrange
            var subtractOperation = new BasicOperation();

            // Act
            var result = subtractOperation.Subtraction(5, 6);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void Division_Calculate_Correct()
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

            // Act and Assert
            Assert.Throws<ZeroDivisorNotAllowedException>(() => { divisionOperation.Division(12, 0); });
        }
        [Test]
        public void Multiplication_Calculate_Correct()
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