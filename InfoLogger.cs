using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanieSystem
{
    class InfoLogger : ILogger
    {
        private ILogger _nextLogger;

        public void SetNext(ILogger logger)
        {
            _nextLogger = logger;
        }
        public void Log(string message, LogLevel level)
        {
            if (level == LogLevel.INFO)
            {
                Console.WriteLine("INFO: " + message);
            }
            else if (_nextLogger != null)
            {
                _nextLogger.Log(message, level);
            }
        }
    }
}
