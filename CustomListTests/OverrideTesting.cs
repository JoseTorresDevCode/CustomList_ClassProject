using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;
using System.Collections.Generic;

namespace CustomListTests
{
    [TestClass]
    public class OverrideTesting
    {
        [TestMethod]
        public void Override_ToString_StringList()
        {
            //arrange
            CustomList<int> test = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            string expected = "123456";
            string actual;

            //act
            actual = test.ToString();
            //assert
            Assert.AreEqual(expected, actual);

        }

       
        
        
    }
}
