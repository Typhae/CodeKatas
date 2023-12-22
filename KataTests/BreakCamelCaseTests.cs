using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Tests
{
    [TestFixture]
    public class BreakCamelCaseTests
    {
        [Test]
        public void testCamelCase()
        {
            Assert.That(BreakCamelCase.CamelCase("camelCasing"), Is.EqualTo("camel Casing"));
            Assert.That(BreakCamelCase.CamelCase("camelCasingTest"), Is.EqualTo("camel Casing Test"));
        }
    }
}
