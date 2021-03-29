using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]

    public class CalculatorTest

    {

        public ICalculator c;

        private int num1;

        private int num2;

        private int addresult;

        [TestInitialize]

        public void TestSeup()

        {

            c = new Calculator();

            num1 = 9;

            num2 = 2;

            addresult = 11;

        }





        [TestMethod]

        public void ShouldAddTwoPositiveNumbers()

        {

            var result = c.Add(num1, num2);

            Assert.AreEqual(addresult, result);

        }



        [TestMethod]

        public void ShouldReturnFirstNumberIfSecondNumberIsZero()

        {

            var result = c.Add(num1, 0);

            Assert.AreEqual(num1, result);

        }
        

    }
}
