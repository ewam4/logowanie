using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanieSystem
{
    class ErrorLogger : ILogger
    {
        private ILogger _nextLogger;

        public void SetNext(ILogger logger)
        {
            _nextLogger = logger;
        }

        public void Log(string message, LogLevel level)
        {
            if (level == LogLevel.ERROR)
            {
                Console.WriteLine("ERROR: " + message);
            }
            else if (_nextLogger != null)
            {
                _nextLogger.Log(message, level);
            }
        }
    }
}
