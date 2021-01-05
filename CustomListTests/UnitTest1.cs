using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_IntToList()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 5;
            //act
            list.Add(5);
            int actualValue = list[0]; //error because doesnt index yet??
            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
        
        [TestMethod]
        public void Add_TwoInts()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 2;

            //act
            list.Add(1);
            list.Add(2);
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Add_String()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string expectedValue = "one";

            //act
            list.Add("one");
            string actualValue = list[0]; //error because doesnt index yet??

            //assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod]
        public void Add_Bool()
        {
            //arrange
            CustomList<bool> list = new CustomList<bool>();
            bool expectedValue = true;

            //act
            list.Add(true);
            bool actualValue = list[0];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Add_WhenFull_DoublesSize()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 8;

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int actualValue = list.capacity;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Add_Maintains_Proper_Index_After_Resizing()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 25;

            //act
            list.Add(1);
            list.Add(25);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int actualValue = list[2]; //error because doesnt index yet??

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Add_CountIncreases()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 1;

            //act
            list.Add(5);
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Add_ListIsNotFull()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            bool expectedValue = false;

            //act
            list.Add(1);
            bool actualValue = list.isFull;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Add_ListIsFull()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            bool expectedValue = true;

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            bool actualValue = list.isFull;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
//resizes when needed
//indexes remain correct after capacity increased
//count increasing when adding items
//






