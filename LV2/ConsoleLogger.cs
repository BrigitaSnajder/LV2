using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class ConsoleLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
