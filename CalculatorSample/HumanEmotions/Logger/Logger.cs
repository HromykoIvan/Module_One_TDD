﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEmotions.Logger
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("logEmotions.txt", message);
        }
    }
}
