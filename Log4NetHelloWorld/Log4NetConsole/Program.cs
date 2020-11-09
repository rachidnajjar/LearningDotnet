using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace Log4NetConsole
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        static void Main(string[] args)
        {
            // Load configuration log4net
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            Console.WriteLine("Hello World!");

            Log.Debug("Application debug");
            Log.Info("Application info");
            Log.Warn("Application warn");
            Log.Error("Application error");
            Log.Fatal("Application fatal");

            // Log some things
            log.Info("Info!");
            log.Warn("Warning!");
            log.Error("Error!");
            log.Fatal("Fatal!");
 
            Console.ReadLine();
        }
    }
}
