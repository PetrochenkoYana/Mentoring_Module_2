using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Module_2_Exception_Handling;
using Moq;

namespace Module_2_Exception_Handling_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Mock<IReadData> mockContainer = new Mock<IReadData>();
        }
    }
}
