using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opg1_TaliaBogLibrary;

namespace Opg1_TaliaBogLibraryTests
{
    [TestClass()]
    public class BogTests
    {
        Bog b1 = new Bog("C# for Beginners", "Talia Damary", 999, "1234567890123");

        [TestMethod()]
        public void TitelOkTest()
        {
            Assert.AreEqual("C# for Beginners", b1.Titel);
            Assert.AreNotEqual("C# for Dummies", b1.Titel);

            Bog b2 = new Bog(null, "Talia Damary", 456, "1234567890123");
            Assert.AreEqual(null, b2.Titel);
            Assert.AreNotEqual("",b2.Titel);

            Bog b3 = new Bog("", "Talia Damary", 456, "1234567890123");
            Assert.AreEqual("", b3.Titel);
            Assert.AreNotEqual(null,b3.Titel);

        }

        [TestMethod()]
        public void ForfatterOkTest()
        {
            Assert.AreEqual("Talia Damary", b1.Forfatter);
            Assert.AreNotEqual("Tamia Damary", b1.Forfatter);

            Bog b2 = new Bog("Javascript 2.0", "TD", 100, "1234567890123");
            Assert.AreEqual("TD", b2.Forfatter);

            Bog b3 = new Bog("Javascript 2.0", "T ", 100, "1234567890123");
            Assert.AreEqual("T ", b3.Forfatter);
        }

        [TestMethod(), ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ForfatterOutOfRangeTest()
        {
            Bog b2 = new Bog("Extreme Programming", "T", 1001, "1234567890123");
        }

        [TestMethod()]
        public void SidetalOkTest()
        {
            Assert.AreEqual(999, b1.Sidetal);
            Assert.AreNotEqual(998, b1.Sidetal);

            Bog b2 = new Bog("Computer Networking","Talia D",4,"1234567890123");
            Assert.AreEqual(4,b2.Sidetal);
            Assert.AreNotEqual(5,b2.Sidetal);
        }

        [TestMethod(), ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SidetalOutOfRangeTest1()
        {
            Bog b2 = new Bog("C# for Dummies", "Talia Damary", 1001, "1234567890123");
        }

        [TestMethod(), ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SidetalOutOfRangeTest2()
        {
            Bog b2 = new Bog("C# for Dummies", "Talia Damary", 3, "1234567890123");
        }

        [TestMethod()]
        public void IsbnOkTest()
        {
            Assert.AreEqual("1234567890123", b1.Isbn);
            Assert.AreNotEqual("1234567890120", b1.Isbn);
        }

        [TestMethod(), ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsbnOutOfRangeTest1()
        {
            Bog b2 = new Bog("C# for Dummies", "Talia Damary", 100, "123456789012");
        }

        [TestMethod(), ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsbnOutOfRangeTest2()
        {
            Bog b2 = new Bog("C# for Dummies", "Talia Damary", 789, "12345678901234");
        }
    }
}
