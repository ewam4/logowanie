using System;

namespace logowanieSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger infoLogger = new InfoLogger();
            ILogger warningLogger = new WarningLogger();
            ILogger errorLogger = new ErrorLogger();

            infoLogger.SetNext(warningLogger);
            warningLogger.SetNext(errorLogger);

            infoLogger.Log("System is running.", LogLevel.INFO);
            infoLogger.Log("Low disk space.", LogLevel.WARNING);
            infoLogger.Log("System crash!", LogLevel.ERROR);
        }
    }
}
