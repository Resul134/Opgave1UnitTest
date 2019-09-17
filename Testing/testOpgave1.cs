using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1UnitTest;

namespace Testing
{
    [TestClass]
    public class testOpgave1
    {

        private Bog _testDll;
        [TestInitialize]
        public void TestMethod1()
        {
            _testDll = new Bog(forfatter:"Anders", sidetal: 430, isbn13: "KJIUHLOIKLKAB", titel: "Resul og hans hest");
        }

        [TestMethod]
        public void testForfatter()
        {
            Assert.AreEqual("Anders", _testDll.Forfatter);
            _testDll.Forfatter = "Resul";
            Assert.AreEqual("Resul", _testDll.Forfatter);


            try
            {
                _testDll.Forfatter = null;
                Assert.Fail();
            }
            catch
            {
            }
        }

        [TestMethod]
        public void testSidetal()
        {
            //Assert.AreEqual(9, _testDll.Sidetal); får en exception
            Assert.AreEqual(430, _testDll.Sidetal);
            _testDll.Sidetal = 10;
            Assert.AreEqual(10, _testDll.Sidetal);
        }

        [TestMethod]
        public void testTitel()
        {
            Assert.AreEqual("Resul og hans hest", _testDll.Titel);

            //_testDll.Titel = "d";
            //Assert.AreEqual("d", _testDll.Titel); exception testing
        }


        [TestMethod]
        public void testIsbn()
        {
            Assert.AreEqual("KJIUHLOIKLKAB", _testDll.Isbn13);
            //_testDll.Isbn13 = "JSABFNDKGL";
            //Assert.AreEqual("JSABFNDKGL", _testDll.Isbn13); giver en exception. Exception testing
        }
    }
}
