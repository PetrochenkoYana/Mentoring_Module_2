using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Exception_Handling
{
    /// <summary>
    /// From my perspective it is not a good way for implementing this task.
    /// Exceptions are mostly used when a code does something unexpected.
    /// In this case the way when user input empty string is absolutly expected behaviour. 
    /// </summary>
    public class ProcessStringDataExceptionHandling : IProcessStringData
    {
        public string ProcessData(string value)
        {
            try
            {
                return value.ToCharArray().First().ToString();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("String should not be empty");
                return null;
            }
        }
    }
}

