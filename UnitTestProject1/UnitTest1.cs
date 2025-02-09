using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _51_UnitTestExample;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PowerSupplyLowerThanZero powerSupplyLowerThanZero = new PowerSupplyLowerThanZero();
            DeskFan deskFan = new DeskFan(powerSupplyLowerThanZero);
            string expected = "Won't work.";
            string actual = deskFan.Work();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerHigherThan200()
        {
            Mock mock = new Mock<IPowerSupply>();
        }
    }

    class PowerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return -1;
        }
    }
}
