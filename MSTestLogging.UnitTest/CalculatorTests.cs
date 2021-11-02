using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestLogging.UnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            AppDomain.CurrentDomain.FirstChanceException += (s, e) => {
                // log the exception here
                //e.Exception.StackTrace
                //e.Exception.Message
                Console.WriteLine(e.Exception.Message);
            };
        }

        [TestMethod]
        public void CalculatorGetDivisionTest()
        {
            var calculator = new Calculator();

            var result = calculator.Division(1, 0);

            Assert.IsNotNull(result);
        }
    }
}
