using DependencyInjection_On_Console.Services;
using System;
namespace DependencyInjection_On_Console
{
    public sealed class Writer
    {
        private readonly ILogger _logger;
        private byte[] bytesToWrite;
        public Writer(ILogger logger)
        {
            _logger = logger;
        }

        private void _write()
        {
            _logger.Write(bytesToWrite);
        }

        public void AskToUser()
        {
            Console.WriteLine("Write anything in the console to save it in a file");
            var data = Console.ReadLine();
            while (string.IsNullOrEmpty(data))
            {
                Console.WriteLine("Please enter a valid text!!!");
            }
            bytesToWrite = System.Text.Encoding.ASCII.GetBytes(data);
            _write();

        }
    }
}
