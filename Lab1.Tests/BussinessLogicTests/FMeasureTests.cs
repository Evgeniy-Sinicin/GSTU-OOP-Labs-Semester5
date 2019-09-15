using Lab1.BussinessLogic.Metrics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Tests.BussinessLogicTests
{
    [TestClass]
    public class FMeasureTests
    {
        [TestMethod]
        public void SimpleTestOfSimpleCalculationQuality()
        {
            var actual = new int[] { 0, 1, 0, 1, 0 };
            var expected = new int[] { 1, 1, 1, 1, 0 };
            var expectedResult = 2d / 3d;
            Assert.AreEqual(new FMeasure().CalculateQuality(actual, expected), expectedResult);        
        }

        [TestMethod]
        public void TestOfSimpleCalculationQualityWhenExpectedQuality100Percents()
        {
            var actual = new int[] { 0, 1, 0, 1, 0 };
            var expected = new int[] { 0, 1, 0, 1, 0 };
            var expectedResult = 1d;
            Assert.AreEqual(new FMeasure().CalculateQuality(actual, expected), expectedResult);
        }

        [TestMethod]
        public void TestOfSimpleCalculationQualityWhenExpectedQualityZeroPercents()
        {
            var actual = new int[] { 1, 0, 1, 0, 1 };
            var expected = new int[] { 0, 1, 0, 1, 0 };
            var expectedResult = 0d;
            Assert.AreEqual(new FMeasure().CalculateQuality(actual, expected), expectedResult);
        }
    }
}
