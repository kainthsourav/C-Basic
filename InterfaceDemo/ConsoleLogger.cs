using System;

namespace InterfaceDemo
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
        }

        public void LogInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
        }
    }
}
