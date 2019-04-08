using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList2._0.Tests
{
    [TestClass()]
    public class CustomListTests
    {
        public TestContext TestContext { get; set; }

        public void Add_intItem_firstIndex()
        {
            
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 3;

            myList.Add(3);

            Assert.AreEqual(expectedResult, myList[0]);
        }

        [TestMethod]
        public void Add_intItem_secondIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 5;

            //Act
            myList.Add(3);
            myList.Add(expectedResult);
            int actualResult = myList[1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_intItem_thirdIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 9;
            //Act
            myList.Add(3);
            myList.Add(5);
            myList.Add(expectedResult);
            int actualResult = myList[2];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}