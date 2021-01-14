using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class OverrideMinusOperator_UnitTest
    {
        [TestMethod]
        public void SubtractionOpperator_SameSizeIntLists_RemoveEvens()
        {
            //arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> evenList = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedValue = new CustomList<int>() { 1, 3, 5 };

            //act
            CustomList<int> actualValue = list - evenList;

            //assert
            Assert.AreEqual(actualValue.ToString(), expectedValue.ToString());

        }

        [TestMethod]
        public void SubtractionOpperator_IntNotInList() //needs better name
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> expectedValue = listOne;

            //act
            CustomList<int> listThree = listOne - listTwo;
            CustomList<int> actualValue = listThree;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void SubtractionOpperator_RemoveEntireIntList()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 1, 2, 3 };
            int expectedValue = 0;

            //act
            CustomList<int> listThree = listOne - listTwo;
            int actualValue = listThree.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
