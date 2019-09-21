using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DependencyInjection_On_Console.Services
{
    class LoggerFile : ILogger
    {
        readonly IConfiguration _config;
        public LoggerFile(IConfiguration config){
            _config = config;
        }
        public void Write(byte[] data){
            string path = Environment.CurrentDirectory;
            using (StreamWriter writer = new StreamWriter(Path.Combine(path, _config["FileName"]), true))
            {
                writer.WriteLine(Encoding.ASCII.GetString(data));
            }
        }
    }
}
