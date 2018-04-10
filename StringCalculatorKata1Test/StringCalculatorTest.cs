using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata1;

namespace StringCalculatorKata1Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void EmptyStringShouldEqual0()
        {
            //Arrange
            StringCalculator testcalc = new StringCalculator();
            //Act
            int result = testcalc.AddString();
            //Assert
            Assert.AreEqual(result, 0);
        }
    }
}
