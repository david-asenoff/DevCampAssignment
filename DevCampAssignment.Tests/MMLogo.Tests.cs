using System;
using NUnit.Framework;

namespace DevCampAssignment.Tests
{
    [TestFixture]
    public class DeviceTests
    {
        private MMLogo mmLogo;

        [SetUp]
        public void Setup()
        {
            mmLogo = new MMLogo('*', '-', 5);
        }

        [Test]
        public void TestConstructure()
        {
            Assert.AreEqual('*', mmLogo.Character);
            Assert.AreEqual('-', mmLogo.Space);
            Assert.AreEqual(5, mmLogo.Width);

            Assert.NotNull(mmLogo.Character);
            Assert.NotNull(mmLogo.Space);
            Assert.NotNull(mmLogo.Width);
        }

        [Test]
        public void TestMakeExceptionDueInvalidIntRange()
        {
            Assert.Throws<ArgumentException>(() => mmLogo = new MMLogo('*', '-', 8));
            Assert.Throws<ArgumentException>(()=>mmLogo = new MMLogo('*', '-', -2));
            Assert.Throws<ArgumentException>(() => mmLogo = new MMLogo('*', '-', 10000));
        }

        [Test]
        public void TestGetStringWorksProperly()
        {
            var expectedLogo = @"-----*****-----*****----------*****-----*****-----
----*******---*******--------*******---*******----
---*********-*********------*********-*********---
--*****-*********-*****----*****-*********-*****--
-*****---*******---*****--*****---*******---*****-
*****-----*****-----**********-----*****-----*****";
            Assert.AreEqual(expectedLogo,mmLogo.GetString());
        }
    }
}