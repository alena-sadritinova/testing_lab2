using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2_test;
using static lab2_test.Coordinates;

namespace test1.Tests
{

    [TestClass()]
    public class Tests
    {

        [TestMethod()]
        public void VectorlenTest1()
        {
            //arrange
            int x = 3;
            int y = 4;
            double expected = 5;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VectorlenTest2()
        {
            //arrange
            int x = -3;
            int y = -4;
            double expected = 5;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VectorlenTest3()
        {
            //arrange
            int x = 0;
            int y = 4;
            double expected = 4;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VectorlenTest4()
        {
            //arrange
            int x = 3;
            int y = 0;
            double expected = 3;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VectorlenTest5()
        {
            //arrange
            int x = -3;
            int y = 0;
            double expected = 3;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VectorlenTest6()
        {
            //arrange
            int x = 0;
            int y = -5;
            double expected = 5;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VectorlenTest7()
        {
            //arrange
            int x = 0;
            int y = -3;
            double expected = 3;
            //act
            Coordinates c = new Coordinates();
            c.Init(x, y);
            double actual = c.Vectorlen();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddTest1()
        {
            //arrange
            Coordinates expected = new Coordinates();
            expected.Init(3, 5);
            //act
            Coordinates a = new Coordinates();
            a.Init(1, 2);
            Coordinates b = new Coordinates();
            b.Init(2, 3);
            Coordinates actual = new Coordinates();
            actual.Init(0, 0);
            actual = actual.Add(a, b);
            //assert
            Assert.IsTrue(expected.Equals(actual));
        }
        [TestMethod()]
        public void AddTest2()
        {
            //arrange
            Coordinates expected = new Coordinates();
            expected.Init(-5, -3);
            //act
            Coordinates a = new Coordinates();
            a.Init(-2, -1);
            Coordinates b = new Coordinates();
            b.Init(-3, -2);
            Coordinates actual = new Coordinates();
            actual.Init(0, 0);
            actual = actual.Add(a, b);
            //assert
            Assert.IsTrue(expected.Equals(actual));
        }
        [TestMethod()]
        public void AddTest3()
        {
            //arrange
            Coordinates expected = new Coordinates();
            expected.Init(0, 3);
            //act
            Coordinates a = new Coordinates();
            a.Init(2, 6);
            Coordinates b = new Coordinates();
            b.Init(-2, -3);
            Coordinates actual = new Coordinates();
            actual.Init(0, 0);
            actual = actual.Add(a, b);
            //assert
            Assert.IsTrue(expected.Equals(actual));
        }
    }
}