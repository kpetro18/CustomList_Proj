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
            int expectedValue = 3;

            //act
            list.Add(1);
            list.Add(2);
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
        public void ToString_ConvertBool()
        {
            //arrange
            CustomList<bool> list = new CustomList<bool>();
            string expectedValue = "True";

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


        //**************************OVERRIDE + OPERATOR TESTS *********************

        [TestMethod]
        public void AddOperator_TwoIntLists()
        {
            //arrange
            CustomList<int> intListOne = new CustomList<int>() { 1, 2, 3};
            CustomList<int> intListTwo = new CustomList<int>() { 4, 5, 6};
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
            CustomList<string> intListOne = new CustomList<string>() {"one", "two", "three"};
            CustomList<string> intListTwo = new CustomList<string>() { "four", "five", "six"};
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

        //**********************OVERRIDE - OPERATOR TESTS*********************

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
            Assert.AreEqual(actualValue, expectedValue);
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

        //*********************ZIP METHOD TESTS ***************

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







