﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListTests
{
    [TestClass]
    public class AddTesting
    {
        
       
        [TestMethod]
        public void Add_AddTwo_CapacityOf4()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 4;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToIndex0_5()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value6 = 5;
            int expected = 5;
            int actual;
            //act
            customList.Add(value6);
            actual = customList[0];

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToFullArray_CapacityWith2Arrays()
        {
            //arrange
            CustomList<int> customList2 = new CustomList<int>();
            int value10 = 1;
            int value11 = 1;
            int value12 = 1;
            int value13 = 1;
            int value14 = 1;         
            int expected = 8;
            int actual;

            //act
            customList2.Add(value10);
            customList2.Add(value11);
            customList2.Add(value12);
            customList2.Add(value13);
            customList2.Add(value14);
            actual = customList2.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToFullArray_OriginalItemRemains()
        {
            //arrange
            CustomList<int> customList2 = new CustomList<int>();
            int value10 = 5;
            int value11 = 1;
            int value12 = 1;
            int value13 = 1;
            int value14 = 1;
            int expected = 5;
            int actual;

            //act
            customList2.Add(value10);
            customList2.Add(value11);
            customList2.Add(value12);
            customList2.Add(value13);
            customList2.Add(value14);
            actual = customList2[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckValueAtLastIndex_EqualsLastValueAdded()
        {
            //arrange
            CustomList<int> customList2 = new CustomList<int>();
            int value3 = 1;
            int value4 = 3;
            int expected = 3;
            
            int actual;

            //act
            customList2.Add(value3);
            customList2.Add(value4);
            actual = customList2[1];

            //assert
            Assert.AreEqual(expected, actual);
        }
       
    }
    
}
