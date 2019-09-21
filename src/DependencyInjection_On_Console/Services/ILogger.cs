using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_On_Console.Services
{
    public interface ILogger
    {
       void Write(byte[] data);
    }
}
