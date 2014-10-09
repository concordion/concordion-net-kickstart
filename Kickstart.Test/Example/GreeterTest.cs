using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kickstart.Example;
using NUnit.Framework;

namespace Kickstart.Test.Example
{
    [TestFixture]
    public class GreeterTest
    {
        [Test]
        public void ShouldGreet()
        {
            var greeter = new Greeter();
            var greeting = greeter.GetMessage();
            Assert.AreEqual("Hello World!", greeting);
        }
    }
}
