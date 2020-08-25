using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListTests
{
    [TestClass]
    public class RemoveTesting
    {
        [TestMethod]
        public void Remove_Removeindex_TotalCountAfterRemoval()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 1;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.RemoveAt(value2);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_AtIndex0_NewValueAtIndex0()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.RemoveAt(0);
            actual = customList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
