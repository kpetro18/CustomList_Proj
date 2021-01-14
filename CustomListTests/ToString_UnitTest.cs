using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class ToString_UnitTest
    {
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

    }
}
