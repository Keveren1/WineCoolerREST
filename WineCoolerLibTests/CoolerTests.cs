using Microsoft.VisualStudio.TestTools.UnitTesting;
using WineCoolerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCoolerLib.Tests
{
    [TestClass()]
    public class CoolerTests
    {
        private Cooler cooler;
        [TestInitialize]
        public void Initialize()
        {
            cooler = new Cooler(1, 48, 10, 48);
        }

        [TestMethod()]
        public void CoolerIsFullTest()
        {
            Cooler cooler3 = new Cooler(2, 48, 10, 4);
            Assert.AreEqual(false, cooler3.CoolerIsFull());
            Assert.AreEqual(true, cooler.CoolerIsFull());
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoolerIsFullTest2()
        {
            Cooler cooler4 = new Cooler(2, 48, 10, 49);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoolerIsFullTest3()
        {
            Cooler cooler4 = new Cooler(2, 48, 10, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddWineTest()
        {
            cooler.AddWine();
        }

        [TestMethod()]
        public void AddWineTest2()
        {
            Cooler cooler3 = new Cooler(2, 48, 10, 44);
            cooler3.AddWine();
            Assert.AreEqual(45, cooler3.AddWine());
        }
    }
}