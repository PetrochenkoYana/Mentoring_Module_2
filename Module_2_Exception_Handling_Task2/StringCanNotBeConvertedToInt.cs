using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Exception_Handling_Task2
{
    public class StringCanNotBeConvertedToInt : ApplicationException
    {

        public StringCanNotBeConvertedToInt(string message):base(message)
        {
        }
    }
}
