using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SampleServiceSwitching.services;

namespace SampleServiceSwitching
{
    class Program
    {
        static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        private static ServiceProvider ConfigureApplication()
        {
            // var builder = new ConfigurationBuilder()
            //     .SetBasePath(Path.Combine(AppContext.BaseDirectory))
            //     .AddJsonFile("appsettings.json", optional: true);
            //
            // Configuration = builder.Build();
            
            var serviceProvider = new ServiceCollection()
                .AddApplicationService()
                .AddTransient<App>()
                .BuildServiceProvider();
            

            var loggerFactory = LoggerFactory.Create(builder => {
                    builder.AddFilter("Microsoft", LogLevel.Warning)
                        .AddConsole();
                }
            );

            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogDebug("Starting application");

            return serviceProvider;
        }
    }
}