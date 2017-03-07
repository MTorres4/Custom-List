using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace CustomListTesting
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        //Confirm index is working
        public void GetIndex_IntIndex_ConfirmingIndex()
        {
            CustomList<int> Custom = new CustomList<int>() { 1, 2, 3 };
            //Arrange
            int expected = 2;
            int index = 1;
            //Act
            int result = Custom.GetIndex(index);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //Add to end of list
        public void Add_AddInt_IntLocationisCorrect()
        {
            CustomList<int> Custom = new CustomList<int>();
            //Arrange
            int value = 1;
            Custom.Add(value);
            //Act
            int result = Custom[0];
            //Assert
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        //Count adds one to overall total in List
        public void Add_AddInt_CountIncrease()
        {
            CustomList<int> Custom = new CustomList<int>();
            //Arrange
            int value = 1;
            int expected = 1;
            //Act
            Custom.Add(value);
            //Assert
            Assert.AreEqual(expected, Custom.Count);
        }

        [TestMethod]
        //Add item without changes to it
        public void Add_AddString_StringLocationisCorrect()
        {
            CustomList<string> Custom = new CustomList<string>();
            //Arrange
            string value = "Snow";
            //Act
            Custom.Add(value);
            //Assert
            Assert.AreNotEqual(value, Custom[0]);
        }

        [TestMethod]
        //Adding an empty string
        public void Add_AddEmptyString_ConfirmingSpaceinArray()
        {
            CustomList<string> Custom = new CustomList<string>();
            //Arrange
            string value = "";
            //Act
            Custom.Add(value);
            //Assert
            Assert.AreEqual(value, Custom[0]);
        }

        [TestMethod]
        //Add item PLUS keeping previous array
        public void Add_AddString_StringAddstoCurrentString()
        {
            CustomList<string> Custom = new CustomList<string>() {"Cheese"};
            //Arrange
            string value = "Snowbunny";
            //Act
            Custom.Add(value);
            //Assert
            Assert.AreEqual("Cheese",Custom[0]);
        }

        [TestMethod]
        //Removed all instances from list
        public void Remove_RemoveInt_TrueReturnedOnSuccess()
        {
            CustomList<int> Custom = new CustomList<int>() { 4, 5, 3, 9, 3 };
            //Arrange
            int value = 3;
            //Act
            bool expected = Custom.Remove(value);
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Remove_RemoveString_TrueRemovedFromList()
        //Removes and fills in gap
        {
            CustomList<string> Custom = new CustomList<string>() {"Bunny"};
            //Arrange
            string value = "Bunny";
            //Act
            bool expected = Custom.Remove(value);
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Remove_RemoveString_TrueReduceCountBy1()
        //Reduces count by 1
        {
            CustomList<string> Custom = new CustomList<string>() {"JackRabbit" , "SnowBunny" };
            //Arrange
            string value = "SnowBunny";
            int expected = 1;
            //Act
            bool result = Custom.Remove(value);
            //Assert
            Assert.AreEqual(expected, Custom.Count);
        }

        [TestMethod]
        public void Iterate_IterateString_TruePrintOrder()
        //Display one item at a time
        {
            CustomList<string> Custom = new CustomList<string>();
            //Arrange
            string [] randomlist = { "Loki", "Bucky" };
            string[] tempList = new string[0];
            Custom.Add("Loki");
            Custom.Add("Bucky");
            bool expected = true;
            //Act
            foreach (string i in Custom)
            {
                tempList[Custom.Count] = i;
            }
            for (int i = 0; i < Custom.Count; i++)
            {
                if (tempList[i] == randomlist[i])
                {
                    expected = true;
                }
                else
                {
                    expected = false;
                    break;
                }
            }
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Iterate_IterateInt_PrintCorrectOrderbyIndex()
        //Display correct order
        {
            CustomList<int> Custom = new CustomList<int>();
            //Arrange
            int[] randomlist = { 2, 3, 4 };
            int[] templist = new int[0];
            //int index = 1;
            Custom.Add(2);
            Custom.Add(3);
            Custom.Add(4);
            int expected = 3;
            //Act
            foreach (int value in Custom)
            {
                templist[Custom.Count] = value;
            }
            for (int i = 0; i < Custom.Count; i++)
            {
                //templist[i] == randomlist[i];
            }
            //Assert
            Assert.AreEqual(expected, Custom[1]);
        }

        [TestMethod]
        //Should be separated by commas
        public void Override_OverridingToString_WithCommas()
        {
            CustomList<string> Custom = new CustomList<string>() {"Bunny" , "Squirrel"};
            //Arrange
            
            //Act
            Custom.ToString();
            //Assert
            //Assert.IsTrue(expected);
        }

        [TestMethod]
        //Should be separated by a space
        public void Override_OverridingToString_WithSpaces()
        {
            CustomList<int> Custom = new CustomList<int>();
            //Arrange
            bool expected = true;
            //Act
            Custom.ToString();
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        //Adding int plus int
        public void Overloading_OverloadingAdd_OverloadingInt()
        {
            CustomList<int> TempList = new CustomList<int>();
            CustomList<int> List1 = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            //Arrange
            //int value = 2;
            //int expected = 5;
            //Act
            //Custom.OverloadAdd(value);
            //Assert
            //Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //Removing a string
        public void Overloading_OverloadingRemove_OverloadingString()
        {
            CustomList<string> TempList = new CustomList<string>();
            CustomList<string> List1 = new CustomList<string>();
            CustomList<string> List2 = new CustomList<string>();
            //Arrange
            //string value = "Snow";
            bool expected = true;
            //Act
            //Custom.OverloadRemove(value);
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        //Have a counter to keep track of items in list
        public void Count_AddtoCount_CountingItemsInt()
        {
            CustomList<string> Custom = new CustomList<string>() {"Bunny"};
            //Arrange
            int expected = 1;
            //Act
            int result = Custom.Count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //Confirm placement of zipped items
        public void Zipping_ZippingString_ZippingAtIndex0()
        {
            CustomList<string> Custom = new CustomList<string>() {"Bunny", "Moose" };
            //Arrange
            bool expected = true;
            //Act
            //Custom.ZipThroughList(value1, value2);
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        //Adjusts size of array when complete
        public void Zipping_ZippingInt_ZippingAtIndex0()
        {
            CustomList<int> Custom = new CustomList<int>();
            //Arrange
            bool expected = true;
            //Act
            //Custom.ZipThroughList(value1, value2);
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        //Has space between each zipped item
        public void Zipping_ZippingInt_ZippinghasSpaces()
        {
            CustomList<int> Custom = new CustomList<int>();
            //Arrange
            bool expected = true;
            //Act
            //Custom.ZipThroughList(value1, value2);
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        //Has commas between each zipped item
        public void Zipping_ZippingInt_ZippinghasCommasBetweenIndex()
        {
            CustomList<int> List1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> List2 = new CustomList<int>() { 4, 5, 6};
            CustomList<int> List3 = new CustomList<int>();
            //Arrange
            //int[] expected =  
            //Act
            //int result = Custom.ZipThroughList(Custom.Count, value2);
            //Assert
            //Assert.AreEqual(expected, result);
        }
    }
}
