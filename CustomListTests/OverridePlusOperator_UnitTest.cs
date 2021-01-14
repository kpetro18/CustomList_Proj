using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class OverridePlusOperator_UnitTest
    {
        [TestMethod]
        public void AddOperator_TwoIntLists()
        {
            //arrange
            CustomList<int> intListOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> intListTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> combinedList = new CustomList<int>();
            int expectedValue = 6;

            //act
            combinedList = intListOne + intListTwo;
            int actualValue = combinedList.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void AddOperator_TwoIntLists_CheckOrder()
        {
            //arrange
            CustomList<int> intListOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> intListTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> combinedList = new CustomList<int>();
            string expectedValue = "123456";

            //act
            combinedList = intListOne + intListTwo;
            string actualValue = combinedList.ToString();

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void AddOperator_TwoStringLists()
        {
            //arrange
            CustomList<string> intListOne = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> intListTwo = new CustomList<string>() { "four", "five", "six" };
            CustomList<string> combinedList = new CustomList<string>();
            int expectedValue = 6;

            //act
            combinedList = intListOne + intListTwo;
            int actualValue = combinedList.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void AddOperator_TwoStringLists_CheckOrder()
        {
            //arrange
            CustomList<string> intListOne = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> intListTwo = new CustomList<string>() { "four", "five", "six" };
            CustomList<string> combinedList = new CustomList<string>();
            string expectedValue = "onetwothreefourfivesix";//might have to capitalize first letters

            //act
            combinedList = intListOne + intListTwo;
            string actualValue = combinedList.ToString();

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
