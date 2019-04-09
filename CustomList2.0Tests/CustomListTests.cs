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

        [TestMethod]
        public void Add_CheckValueAtIndex_Equal()
        {
            CustomList<int> primeNos = new CustomList<int>();
            int expectedResult = 11;

            primeNos.Add(3);
            primeNos.Add(5);
            primeNos.Add(7);
            primeNos.Add(11);
            primeNos.Add(13);
            primeNos.Add(17);

            Assert.AreEqual(expectedResult, primeNos[3]);
        }

        //throws out of bound exception
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_OutOfBound_ThrowException()
        {
            CustomList<int> numbers = new CustomList<int>(5);
            int expectedResult;
            
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            
            expectedResult = numbers[6];
        }

        [TestMethod]
        public void Add_intItem_givenIndex()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 3;

            myList.Add(1);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            myList.Add(11);
            myList.Add(3, 1);
            
            Assert.AreEqual(expectedResult, myList[1]);

        }

        [TestMethod]
        public void Resize_value_doesResize()
        {
            CustomList<int> primeNos = new CustomList<int>() { 3, 5, 7 };
            int expectedValue = 8;
            int actualValue;

            primeNos.Add(9);
            primeNos.Add(11);
            actualValue = primeNos.capacity;

            
            Assert.AreEqual(expectedValue, actualValue);

        }


        [TestMethod]
        //Test for Count
        public void Count_ListItems_IsRight()
        {
            
            CustomList<int> primeNos = new CustomList<int>() { 3, 5, 7, 9, 11, 13 };
            int expectedResult = 6;

            
            int actualResult = primeNos.count;

            
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Count_ListItems_IsWrong()
        {
            
            CustomList<int> primeNos = new CustomList<int>() { 3, 5, 7, 9, 11, 13 };
            int expectedResult = 6;
            int actualResult = primeNos.count;
            
            primeNos.Add(17);
            actualResult = primeNos.count;

            
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_ListItems_firstIndex()
        {
            CustomList<string> weekdays = new CustomList<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Monday" };
            string expectedResult = "Tuesday";
            string actualResult;

            weekdays.Remove("Monday");
            actualResult = weekdays[0];

            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_ListItems_SecondIndex()
        {
            
            CustomList<string> weekdays = new CustomList<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string expectedResult = "Wednesday";
            string actualResult;
            

            weekdays.Remove("Tuesday");
            actualResult = weekdays[1];
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_MultipleInstances_False()
        {
            CustomList<int> numbers = new CustomList<int>() { 1, 2, 3, 2, 5, 2, 7 };
            int expectedCount = 6;
            int actualCount;

            
            numbers.Remove(2);
            actualCount = numbers.count;
            
            Assert.AreEqual(expectedCount, actualCount);
        }

        //check to see if nothing is removed
        [TestMethod]
        public void Remove_NoMatch_NoRemove()
        {
            
            CustomList<string> weekdays = new CustomList<string>() { "monday", "tuesday", "wednesday", "thursday", "friday" };
            int actualCount;
            
            weekdays.Remove("sunday");
            actualCount = weekdays.count;
            
            Assert.IsTrue(actualCount == 5);

        }

    }
}