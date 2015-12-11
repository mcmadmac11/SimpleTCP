using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP.Tests
{
    [TestClass()]
    public class ByteArrayTests
    {
        [TestMethod()]
        public void get_dataOffsetTest()
        {
            get_dataOffsetTest(bool false);
            Assert.Fail();
        }
    }
}