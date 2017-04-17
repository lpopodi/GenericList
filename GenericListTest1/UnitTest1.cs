using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace GenericListTest1
{
    [TestClass]
    public class UnitTest1
    {
           [TestMethod]
            public void IntAddTest()
            {
                //Arrange
                GenericList<int> GenericList = new GenericList<int>();
                int item = 5;

                //Act
                GenericList.Add(item);

                //Assert
                Assert.AreEqual(item, GenericList[0]);
            }


            [TestMethod]
            public void StringAddTest()
            {
                //Arrange
                GenericList<string> GenericList = new GenericList<string>();
                string item = "This is my string";

                //Act
                GenericList.Add(item);

                //Assert
                Assert.AreEqual(item, GenericList[0]);
            }


            [TestMethod]
            public void ObjectAddTest()
            {
                GenericList<Item> GenericList = new GenericList<Item>();
                Item item = new Item("stuff", 34, "more");

                GenericList.Add(item);

                Assert.AreEqual(item, GenericList[0]);
            }


            [TestMethod]
            public void IntRemoveTest()
            {
                GenericList<int> GenericList = new GenericList<int>();
                int removeItem = 1;
                GenericList.Add(removeItem);
                GenericList.Add(2);
                GenericList.Add(3);

                int result = GenericList.Remove();

                Assert.AreEqual(removeItem, result);
            }

            [TestMethod]
            public void StringRemoveTest()
            {
                GenericList<string> GenericList = new GenericList<string>();
                string removeItem = "Buh Bye";
                GenericList.Add(removeItem);
                GenericList.Add("Staying");
                GenericList.Add("Keep");

                string result = GenericList.Remove();

                Assert.AreEqual(removeItem, result);
            }

            [TestMethod]
            public void ObjectRemoveTest()
            {
                GenericList<Item> GenericList = new GenericList<Item>();

                Item item = new Item();
                GenericList.Add(item);
                bool result;

                result = GenericList.Remove(item);


                Assert.AreEqual(true, result);
            }


            [TestMethod]
            public void IntToStringTest()
            {
                GenericList<int> GenericList = new GenericList<int>();
                int item = 1;
                GenericList.Add(item);

                string result = GenericList.ToString();

                Assert.AreEqual(item, result);
            }

            [TestMethod]
            public void stringToStringTest()
            {
                GenericList<string> GenericList = new GenericList<string>();
                string item = "Add Item";
                GenericList.Add(item);

                string result = GenericList.ToString();

                Assert.AreEqual(item, result);
            }

            [TestMethod]
            public void ToStringObjects()
            {
                Item item1 = new Item();
                item item2 = new Item();
                item1 item3 = new Item();
                GenericList<Item> GenericList = new GenericList<Item>() { item1, item2, item3 };

                string expected = $"{item1}, {item2}, {item3}";
                string result;

                result = GenericList.ToString();

                Assert.AreEqual(expected, result);
            }


            [TestMethod]
            public void IntPlusTest()
            {

                GenericList<int> first = new GenericList<int>() { 1, 2, 3 };
                GenericList<int> second = new GenericList<int>() { 4, 5, 6 };
                GenericList<int> expected = new GenericList<int>() { 1, 2, 3, 4, 5, 6 };
                GenericList<int> result;


                result = first + second;


                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void StringPlusTest()
            {

                GenericList<string> first = new GenericList<string>() { "Lets", "run", "these" };
                GenericList<string> second = new GenericList<string>() { "two", "strings", "together" };
                GenericList<string> expected = new GenericList<string>() { "Lets", "run", "these", "two", "strings", "together" };
                GenericList<string> result;


                result = first + second;


                for (string i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void ObjectPlusTest()
            {
                Item item1 = new Item();
                Item item2 = new Item();
                Item item3 = new Item();

                GenericList<Item> first = new GenericList<Item>() { item1, item2 };
                GenericList<Item> second = new GenericList<Item>() { item3 };
                GenericList<Item> expected = new GenericList<Item>() { item1, item2, item3 };
                GenericList<Item> result;


                result = first + second;

                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void IntMinusTest()
            {

                GenericList<int> first = new GenericList<int>() { 1, 2, 3, 4, 5, 6 };
                GenericList<int> second = new GenericList<int>() { 2, 4, 6 };
                GenericList<int> expected = new GenericList<int>() { 1, 3, 5 };
                GenericList<int> result;

                result = first - second;


                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void StringMinusTest()
            {

                GenericList<string> first = new GenericList<string>() { "Lets", "drop", "some", "strings", "from", "list" };
                GenericList<string> second = new GenericList<string>() { "Lets", "some", "list" };
                GenericList<string> expected = new GenericList<string>() { "drop", "strings", "list" };
                GenericList<string> result;

                result = first - second;


                for (string i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void ObjectMinusTest()
            {
                Item item1 = new Item();
                Item item2 = new Item();
                Item item3 = new Item();

                GenericList<Item> first = new GenericList<Item>() { item1, item2, item3 };
                GenericList<Item> second = new GenericList<Item>() { item2 };
                GenericList<Item> expected = new GenericList<Item>() { item1, item3 };
                GenericList<Item> result;

                result = first - second;

                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }


            [TestMethod]
            public void IntCountTest()
            {
                int size = 100;
                GenericList<int> GenericList = new GenericList<int>();
                for (int i = 0; i < size; i++)
                {
                    GenericList.Add(i);
                }

                int result = GenericList.Count();

                Assert.AreEqual(size, result);
            }

            [TestMethod]
            public void StringCountTest()
            {
                string[] newString = new string[] { "Counting", "Strings", "is", "fun" };
                GenericList<string> GenericList = new GenericList<string>();
                for (int i = 0; i < newString.Length; i++)
                {
                    GenericList.Add(names[i]);
                }

                int result = GenericList.Count();

                Assert.AreEqual(newString.Length, result);
            }


            [TestMethod]
            public void ZipIntsTest()
            {

                GenericList<int> odd = new GenericList<int>() { 1, 3, 5 };
                GenericList<int> even = new GenericList<int>() { 2, 4, 6 };
                GenericList<int> expected = new GenericList<int>() { 1, 2, 3, 4, 5, 6 };
                GenericList<int> result;

                result = odd.Zip(even);

                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void ZipstringsTest()
            {

                GenericList<string> odd = new GenericList<string>() { "Green Bay", "Pittsburgh", "Dallas" };
                GenericList<string> even = new GenericList<string>() { "Packers", "Steelers", "Cowboys" };
                GenericList<string> expected = new GenericList<string>() { "Green Bay", "Packers", "Pittsburgh", "Steelers", "Dallas", "Cowboys" };
                GenericList<string> result;

                result = odd.Zip(even);


                for (string i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

            [TestMethod]
            public void Zip_Items()
            {
                Item item1 = new Item();
                Item item2 = new Item();
                Item item3 = new Item();

                GenericList<Item> first = new GenericList<Item>() { item1, item3 };
                GenericList<Item> second = new GenericList<Item>() { item2 };
                GenericList<Item> expected = new GenericList<Item>() { item1, item2 };
                GenericList<Item> result;

                result = first.Zip(second);

                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(result[i], expected[i]);
                }
            }

        }
}
