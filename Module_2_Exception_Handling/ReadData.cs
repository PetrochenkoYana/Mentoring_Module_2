using System;

namespace Module_2_Exception_Handling
{
    public interface IReadData
    {
        string Read();
    }

    public class ReadData : IReadData
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
