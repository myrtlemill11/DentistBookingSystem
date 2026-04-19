using System;
using System.IO;

namespace consoleBookingSystem2.Business
{
    public class Logger
    {
        private string logFile = "system.log";

        public void Write(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFile, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch { }
        }
    }
}
