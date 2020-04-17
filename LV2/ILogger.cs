﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    interface ILogger
    {
        void Log(string message);

        void Log(ILogable data);
    }
}
