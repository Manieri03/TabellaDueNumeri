using MetodiDueNumeri;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDueNumeri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Massimo1()
        {
            double r = MinMaxMed.Max(5, 2);
            Assert.AreEqual(r, 5);
        }
        [TestMethod]
        public void Massimo2()
        {
            double r = MinMaxMed.Max(3, 4);
            Assert.AreEqual(r, 4);
        }
        [TestMethod]
        public void Massimo3()
        {
            double r = MinMaxMed.Max(7, 7);
            Assert.AreEqual(r, 7);
        }
        [TestMethod]
        public void Minimo1()
        {
            double r = MinMaxMed.Min(5, 2);
            Assert.AreEqual(r, 2);
        }
        [TestMethod]
        public void Minimo2()
        {
            double r = MinMaxMed.Min(3, 4);
            Assert.AreEqual(r, 3);
        }
        [TestMethod]
        public void Minimo3()
        {
            double r = MinMaxMed.Min(7, 7);
            Assert.AreEqual(r, 7);
        }
        [TestMethod]
        public void Media1()
        {
            double r = MinMaxMed.Media(5, 2);
            Assert.AreEqual(r, 3.5);
        }
        [TestMethod]
        public void Media2()
        {
            double r = MinMaxMed.Media(3, 4);
            Assert.AreEqual(r, 3.5);
        }
        [TestMethod]
        public void Media3()
        {
            double r = MinMaxMed.Media(7, 7);
            Assert.AreEqual(r, 7);
        }
    }
}
