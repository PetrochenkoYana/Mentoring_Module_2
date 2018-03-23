using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadData readData = new ReadData();
            IProcessStringData processStringData = new ProcessStringDataExceptionHandling();
            while (true)
            {
                var enteredString = readData.Read();
                if (enteredString != "exit")
                {
                    var resultString = processStringData.ProcessData(enteredString);
                    if (resultString != null)
                        Console.WriteLine(resultString);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
