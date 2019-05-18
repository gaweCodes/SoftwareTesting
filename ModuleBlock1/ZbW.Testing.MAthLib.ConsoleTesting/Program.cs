using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZbWTesting.MathLib.Library;

namespace ZbW.Testing.MAthLib.ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var bo = new BasicOperations();
            if(bo.Addition(2,2) == 4)
                Console.WriteLine("Add Test ok");
            if(bo.Subtraction(5,7) == -2)
                Console.WriteLine("Subtract Test ok");
            if(Math.Abs(bo.Division(5,2) - double.Parse("2.5")) < 0.1)
                Console.WriteLine("Divide Test ok");
            try
            {
                bo.Division(2, 0);
            }
            catch (ZeroDivisorNotAllowedException e)
            {
                Console.WriteLine("Division by 0 test is ok");
            }
            if(bo.Multiplication(3,5) == 15)
                Console.WriteLine("Multiplication Test is ok");

            Console.ReadLine();
        }
    }
}
