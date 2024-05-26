using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanieSystem
{
    interface ILogger
    {
        void SetNext(ILogger logger);
        void Log(string message, LogLevel level);
    }
    enum LogLevel
    {
        INFO,
        WARNING,
        ERROR
    }
}
