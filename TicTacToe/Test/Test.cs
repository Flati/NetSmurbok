using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void testSomething()
        {
            int a = 0;
            Assert.AreEqual(a, a, "Whupwhup");
        }
    }
}
