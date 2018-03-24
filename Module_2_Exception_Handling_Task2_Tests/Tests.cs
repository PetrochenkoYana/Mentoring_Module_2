using NUnit.Framework;
using Module_2_Exception_Handling_Task2;

namespace Module_2_Exception_Handling_Task2_Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("345", 345)]
        [TestCase("045", 45)]
        [TestCase("-2345",-2345)]
        [TestCase("-343535", -343535)]
        public void ConvertStringToInt(string enteredString, int number)
        {
            IProcessString processString = new ProcessString();

            var resultNumber = processString.ConvertStringToInt(enteredString);

            Assert.AreEqual(number, resultNumber);
        }

        [Test]
        public void ExceptionShouldArise()
        {
            try
            {
                string enteredString = "fdgdg";
                IProcessString processString = new ProcessString();

                var resultNumber = processString.ConvertStringToInt(enteredString);

                Assert.Fail("no exception thrown");
            }
            catch (StringCanNotBeConvertedToInt ex)
            {
                Assert.IsTrue(ex is StringCanNotBeConvertedToInt);
            }

        }
    }
}
