using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("This is a log message.");
            Logger.LogMessage("Another log message.");
            Console.ReadKey();
        }
    }
}

