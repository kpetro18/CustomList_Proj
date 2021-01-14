using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class Remove_UnitTest
    {
        [TestMethod]
        public void Remove_Int()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 0;

            //act
            list.Add(1);
            list.Remove(1);
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Remove_String()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            int expectedValue = 0;

            //act
            list.Add("one");
            list.Remove("one");
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Remove_CountDecreases()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 1;

            //act
            list.Add(1);
            list.Add(2);
            list.Remove(2);
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Remove_IndexZero_ItemsShiftDown()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 3;

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);
            int actualValue = list[1];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Remove_OutOfBoundsIndex()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 3;

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(5);
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod]
        public void Remove_One_WhenListHasMuplitple()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 1;

            //act
            list.Add(1);
            list.Add(2);
            list.Add(1);
            list.Add(1);
            list.Remove(1);
            int actualValue = list[1];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
