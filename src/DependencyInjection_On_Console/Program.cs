using DependencyInjection_On_Console.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.IO.Abstractions;

namespace DependencyInjection_On_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureHostConfiguration(configHost => {  
                    configHost.SetBasePath(Directory.GetCurrentDirectory());
                    configHost.AddJsonFile("settings.json", optional: false);
                })
                .ConfigureServices((hostContext, services) => {
                    ConfigureServices(hostContext, services);
                })
                .Build();
           
            Writer writer = host.Services.GetService<Writer>();
            writer.AskToUser();

        }

        //Add dependency services
        static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<ILogger, LoggerFile>();
            services.AddTransient<Writer>();

        }
    }

    
}
