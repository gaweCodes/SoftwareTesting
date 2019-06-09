using System;
using System.Linq;

namespace FirstUnitTests
{
    public class FunctionRepository
    {
        public bool GreaterThan10(int numberToCheck)
        {
            const int numberToCheckWith = 10;
            return numberToCheck > numberToCheckWith;
        }
        public bool IsValidMailAddress(string address) => address.Contains("@") && address.Contains(".");
        public bool IsStringLongerThan10(string stringToCheck)
        {
            const int stringLengthToCheck = 10;
            return !string.IsNullOrEmpty(stringToCheck) && stringToCheck.Length > stringLengthToCheck;
        }
        public int GetStringLength(string text) => string.IsNullOrEmpty(text) ? 0 : text.Length;
        public bool AreNumbersInString(string text) => text.Any(char.IsDigit);
        public string ToUpper(string text) => text.ToUpper();
        public string ToLower(string text) => text.ToLower();
        public bool IsValidInt(string text) => int.TryParse(text, out var testInt);

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return dividend / divisor;
        }
        public decimal Multiply(decimal number1, decimal number2) => number1 * number2;
        public decimal Sum(decimal number1, decimal number2) => number1 + number2;
        public decimal Sub(decimal number1, decimal number2) => number1 - number2;
    }
}
