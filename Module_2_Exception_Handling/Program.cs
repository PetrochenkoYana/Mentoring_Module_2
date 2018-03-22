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
            ProcessStringDataExceptionHandling psStringData =new ProcessStringDataExceptionHandling(new ReadData());
            ProcessStringDataTryMethod tryMethod = new ProcessStringDataTryMethod(new ReadData());
            tryMethod.ProcessData();
        }
    }
}
