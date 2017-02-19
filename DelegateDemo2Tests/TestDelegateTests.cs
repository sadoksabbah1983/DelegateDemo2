using Microsoft.VisualStudio.TestTools.UnitTesting;
using DelegateDemo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2.Tests
{
    [TestClass()]
    public class TestDelegateTests
    {
        [TestMethod()]
        public void AddNumTest()
        {
            int x = 5;
            int y = 10;
            int expected = 15;
            int actual = 15;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void MulNumTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNumTest()
        {
            Assert.Fail();
        }
    }
}