﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
