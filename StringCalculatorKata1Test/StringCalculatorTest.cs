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

        [TestMethod]
        public void OneStringShouldEqualItself()
        {
            //Arrange
            StringCalculator testcalc = new StringCalculator();
            //Act
            int result = testcalc.AddString("4");
            //Assert
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Strings1and2ShouldEqual3()
        {
            //Arrange
            StringCalculator testcalc = new StringCalculator();
            //Act
            int result = testcalc.AddString("1","2");
            //Assert
            Assert.AreEqual(result, 3);
        }
    }
}
