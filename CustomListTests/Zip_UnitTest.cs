using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class Zip_UnitTest
    {
        [TestMethod]
        public void Zip_TwoSameSizeIntLists()
        {
            //arrange
            CustomList<int> oddList = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evenList = new CustomList<int>() { 2, 4, 6 };
            int expectedValue = 3;

            //act
            CustomList<int> zippedList = oddList.Zip(evenList);
            int actualValue = zippedList[2];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Zip_TwoDifferentSizeIntLists_SecondListIsLonger()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 5, 6, 7, 8, 9, 10 };
            int expectedValue = 7;

            //act
            CustomList<int> zippedList = listOne.Zip(listTwo);
            int actualValue = zippedList[6];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Zip_TwoDifferentSizeIntLists_FirstListIsLonger()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5, 6, 7, 8, 9 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4 };
            int expectedValue = 7;

            //act
            CustomList<int> zippedList = listOne.Zip(listTwo);
            int actualValue = zippedList[6];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Zip_TestEmptyIntList()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>();
            int expectedValue = 2;

            //act
            CustomList<int> zippedList = listOne.Zip(listTwo);
            int actualValue = zippedList[1];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
