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
        public void Add_ListIsFull()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = list.capacity;

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int actualValue = list.Count;

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        //**************************REMOVE() METHOD TESTS********************

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
            list.Remove(list[0]);
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
            list.Remove(list[1]);
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

        //**************************TOSTRING METHOD TESTS********************

        [TestMethod]
        public void ToString_ConvertInt()
        {
            CustomList<int> list = new CustomList<int>();
            string expectedValue = "1";
           
            //act
            list.Add(1);
            string actualValue = list.ToString();

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void ToString_ConvertDouble()
        {
            CustomList<int> list = new CustomList<int>();
            string expectedValue = "1";

            //act
            list.Add(1.05);
            list.ToString(list[0]);
            string actualValue = list[0];

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void ToString_ConvertBool()
        {
            //arrange
            CustomList<bool> list = new CustomList<bool>();
            string expectedValue = "true";

            //act
            list.Add(true);          
            string actualValue = list.ToString();

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void ToString_UsingLargeList()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            string expectedValue = "123456";

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            string actualValue = list.ToString();

            //assert
            Assert.AreEqual(actualValue, expectedValue);
        }
    }


    //maintains proper index
    //other items indexed do not change
}


//add multiple values to list and string whole thing
//ToString turns whole list into string
//remove method searches list then removes first matching item found
//multiple of same value does it only remove one





