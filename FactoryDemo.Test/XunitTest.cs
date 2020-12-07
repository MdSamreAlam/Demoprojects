using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using InterfaceDemo;


namespace FactoryDemo.Test
{
    [TestClass]
    public class XunitTest
    {
       [Fact]
        public void TestSiCiDemo()
        {
            //Arrange
            I1 i1 = FactoryClass.GetSiCi(0);

            //Act
            float result = i1.Interest(10,20,30);
            double result1 = i1.CalculateCompoundInterest(1000, 0.07, 1);
            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(60, result);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1070, result1);
        }
    }
}
