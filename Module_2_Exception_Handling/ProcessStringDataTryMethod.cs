using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Exception_Handling
{
    /// <summary>
    /// This implementation doesn't allow exception to be thrown
    /// If entered data has inappropriate format user recieve a notification
    /// </summary>
    public class ProcessStringDataTryMethod : IProcessStringData
    {
        public IReadData ReadData { get; set; }

        public ProcessStringDataTryMethod(IReadData readData)
        {
            ReadData = readData;
        }

        private static bool TryProcess(string data, out string symbol)
        {
            if (string.IsNullOrEmpty(data))
            {
                symbol = null;
                return false;
            }
            symbol = data.ToCharArray().First().ToString();
            return true;
        }
        public void ProcessData()
        {
            while (true)
            {
                string symbol;
                bool attempt = TryProcess(ReadData.Read(), out symbol);
                Console.WriteLine(attempt ? symbol : "String should not be empty");
            }
        }
    }
}
