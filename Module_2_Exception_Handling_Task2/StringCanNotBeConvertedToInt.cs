using System;

namespace Module_2_Exception_Handling_Task2
{
    public class StringCanNotBeConvertedToInt : ApplicationException
    {

        public StringCanNotBeConvertedToInt(string message):base(message)
        {
        }
    }
}
