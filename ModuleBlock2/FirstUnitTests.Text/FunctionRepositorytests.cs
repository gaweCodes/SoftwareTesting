using System;
using NUnit.Framework;

namespace FirstUnitTests.Text
{
    [TestFixture]
    public class FunctionRepositoryTests
    {
        private FunctionRepository _functions;
        [SetUp]
        public void Init()
        {
            _functions = new FunctionRepository();
        }
        [Test]
        public void GreaterThan10Test()
        {
            var greaterThanResult = _functions.GreaterThan10(25);
            Assert.IsTrue(greaterThanResult);
        }
        [Test]
        public void IsValidMailAddressTest()
        {
            var isValid = _functions.IsValidMailAddress("gawe@rey.ch");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void StringLongerThan10Test()
        {
            var longerThanResult = _functions.IsStringLongerThan10("Dies ist ein Satz mit mehr als 10 Zeicchen, nehme ich mal an.");
            Assert.IsTrue(longerThanResult);
        }
        [Test]
        public void GetStringLength()
        {
            var length = _functions.GetStringLength("Test.");
            Assert.AreEqual(length, 5);
        }
        [Test]
        public void AreNumbersInStringTest()
        {
            var hasNumbers = _functions.AreNumbersInString("Hallo123Welt");
            Assert.IsTrue(hasNumbers);
        }
        [Test]
        public void ToUpperTest()
        {
            var upperString = _functions.ToUpper("Hallo123Welt");
            Assert.AreEqual(upperString, "HALLO123WELT");
        }
        [Test]
        public void ToLowerTest()
        {
            var lowerString = _functions.ToLower("Hallo123Welt");
            Assert.AreEqual(lowerString, "hallo123welt");
        }
        [Test]
        public void IsValidIntTest()
        {
            var validated = _functions.IsValidInt("25");
            Assert.IsTrue(validated);
        }
        [Test]
        public void DivideTest()
        {
            var result = _functions.Divide(25, 5);
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void DivideTest2()
        {
            var result = _functions.Divide(15, 2);
            Assert.AreEqual(result, 7.5m);
        }
        [Test]
        public void DivideTestByZero()
        {
            Assert.Throws<DivideByZeroException>(() => { _functions.Divide(15, 0); });
        }
        [Test]
        public void MultiplyTest()
        {
            var result = _functions.Multiply(25, 5);
            Assert.AreEqual(result, 125);
        }
        [Test]
        public void MultiplyTest2()
        {
            var result = _functions.Multiply(25, 10);
            Assert.AreEqual(result, 250);
        }
        [Test]
        public void MultiplyTest3()
        {
            var result = _functions.Multiply(123, 10);
            Assert.AreEqual(result, 1230);
        }
        [Test]
        public void MultiplyTest4()
        {
            var result = _functions.Multiply(-24.25m, -200);
            Assert.AreEqual(result, 4850);
        }
        [Test]
        public void MultiplyByZeroTest()
        {
            var result = _functions.Multiply(25, 0);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void SumTest()
        {
            var sum = _functions.Sum(1.8m, 5);
            Assert.AreEqual(sum, 6.8);
        }
        [Test]
        public void SumTest2()
        {
            var sum = _functions.Sum(7, 15);
            Assert.AreEqual(sum, 22);
        }
        [Test]
        public void SumTest3()
        {
            var sum = _functions.Sum(90, 30);
            Assert.AreEqual(sum, 120);
        }
        [Test]
        public void SubtractTest()
        {
            var result = _functions.Sub(15, 3);
            Assert.AreEqual(result,12);
        }
        [Test]
        public void SubtractTest2()
        {
            var result = _functions.Sub(15, 20);
            Assert.AreEqual(result, -5);
        }
    }
}
