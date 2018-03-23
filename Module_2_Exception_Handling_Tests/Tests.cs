using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Module_2_Exception_Handling;

namespace Module_2_Exception_Handling_Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(" A p c t r "," ")]
        [TestCase("", null)]
        [TestCase("A p c t r ", "A")]
        [TestCase(" ", " ")]
        public void Test(string enteredString, string result )
        {
            IProcessStringData processStringData = new ProcessStringDataExceptionHandling();

            var resultString = processStringData.ProcessData(enteredString);

            Assert.AreEqual(resultString,result);
        }
    }
}
