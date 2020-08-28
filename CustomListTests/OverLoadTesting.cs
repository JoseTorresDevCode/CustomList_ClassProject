using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;
using System.Collections.Generic;
using CustomListTests;

namespace CustomListTests
{
    [TestClass]
    public class OverLoadTesting
    {
        [TestMethod]
        public void Overload_CombineTwoLists_Consecutive()
        {
            //arrange
            CustomList<int> test1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> test2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> combinedList = new CustomList<int>();
            
            string expected = "135246";
            string actual = combinedList.ToString();

            //act
            combinedList = test1 + test2;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
