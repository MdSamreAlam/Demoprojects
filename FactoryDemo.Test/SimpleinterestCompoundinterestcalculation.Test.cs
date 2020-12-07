using InterfaceDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FactoryDemo.Test
{
    [TestClass]
    public class SimpleinterestCompoundinterestcalculation
    {
        [Fact]
        public void TestSiCiDemo()
        {
            //Arrange
            I1 i1 = FactoryClass.GetSiCi(0);

            //Act
            float result = i1.Interest(10, 20, 30);
            double result1 = i1.CalculateCompoundInterest(1000, 0.07, 1);
            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(60, result);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1070, result1);
        }
        [Fact]
        public void TestSiCiDemo1()
        {
            //Arrange
            I1 i2 = FactoryClass.GetSiCi(0);
            //Act
            float res = i2.Interest(40, 50, 20);
            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(100, res);
            


        }
    }
}
