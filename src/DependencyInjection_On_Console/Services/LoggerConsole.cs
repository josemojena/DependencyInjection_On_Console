using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_On_Console.Services
{
    class LoggerConsole : ILogger
    {
        public void Write(byte[] data)
        {
            Console.WriteLine(Encoding.ASCII.GetString(data));
        }
    }
}
