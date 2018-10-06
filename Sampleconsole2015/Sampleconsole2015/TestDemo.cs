using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole2015
{
    [TestFixture]
    class TestDemo
    {
        [TestCase]
        public void add()
        {
            MyClass MC1 = new MyClass();
                Assert.AreEqual(200, MC1.add(10, 200));


        }
    }
}
