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
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        public void Add_intItem_firstIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 3;


            //Act
            myList.Add(3);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
    }
}