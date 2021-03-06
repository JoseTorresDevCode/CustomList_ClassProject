﻿using System;
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
            customList.Remove(value2);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_DuplicateItems_OnlyFirstInstanceRemoved()
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
            customList.Add(value1);
            customList.Remove(1);
            actual = customList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_AtIndex1_NewValueOutofRange()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Remove(1);
            actual = customList[1];

        }

        [TestMethod]
        public void Remove_RemoveValueNotInList_CustomListCountDoesNotchange()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int removeValue1 = 100;
            int expected = 5;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(removeValue1);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ValueFromListTwice_ReturnFalse()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expected = false;
            bool actual;

            //act 
            
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Remove(value3);
            actual = customList.Remove(value3);
            //actual = customList.Remove;

            //assert
            Assert.AreEqual(expected, actual);


        }
    }
}
