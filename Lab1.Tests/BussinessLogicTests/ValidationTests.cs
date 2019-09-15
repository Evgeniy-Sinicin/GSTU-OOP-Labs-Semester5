using Lab1.BussinessLogic.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests.BussinessLogicTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void IsTheLengthOfArraysTheSameIfWeTakeArraysOfDifferentLengths()
        {
            var aLong = new int[] { 0, 1, 0, 1, 0 };
            var aShort = new int[] { 1 };
            var expected = false;
            Assert.AreEqual(Validation.IsArraysLengthEqual(aLong, aShort), expected);
        }

        [TestMethod]
        public void IsTheLengthOfArraysTheSameIfWeTakeArraysOfTheSameLengths()
        {
            var array1 = new int[] { 0, 1, 0, 1, 0 };
            var array2 = new int[] { 1, 0, 0, 0, 1 };
            var expected = true;
            Assert.AreEqual(Validation.IsArraysLengthEqual(array1, array2), expected);
        }

        [TestMethod]
        public void IsTheLengthOfArraysTheSameIfWeTakeEmptyArrays()
        {
            int[] array1 = { };
            int[] array2 = { };
            var expected = true;
            Assert.AreEqual(Validation.IsArraysLengthEqual(array1, array2), expected);
        }

        [TestMethod]
        public void IsAnArrayEmptyIfItIsFull()
        {
            var fullArray = new int[] { 1,0,1,0 };
            var expected = false;
            Assert.AreEqual(Validation.IsArrayEmpty(fullArray), expected);
        }

        [TestMethod]
        public void IsAnArrayEmptyIfItIsEmpty()
        {
            var fullArray = new int[] { };
            var expected = true;
            Assert.AreEqual(Validation.IsArrayEmpty(fullArray), expected);
        }

        [TestMethod]
        public void DoesTheArrayContainOnly0And1IfItContainsOtherDigits()
        {
            var fullArray = new int[] { 1, 0, 1, 0, 2, 0, 0 };
            var expected = false;
            Assert.AreEqual(Validation.DoesArrayContainOnly0and1Numbers(fullArray), expected);
        }

        [TestMethod]
        public void DoesTheArrayContainOnly0And1IfItContainsOnlyTheseDigits()
        {
            var fullArray = new int[] { 1, 0, 1, 0, 1, 0, 0 };
            var expected = true;
            Assert.AreEqual(Validation.DoesArrayContainOnly0and1Numbers(fullArray), expected);
        }

        [TestMethod]
        public void DoesTheArrayContainOnly0And1IfItContainsNothing()
        {
            var fullArray = new int[] { };
            var expected = true;
            Assert.AreEqual(Validation.DoesArrayContainOnly0and1Numbers(fullArray), expected);
        }
    }
}
