using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public static class RegisterServiceCollection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service)
        {
            service.AddScoped<ICommunicationService, TwitterCommunicationService>();
            service.AddScoped<ICommunicationService, LinkedLnCommunicationService>();
            service.AddScoped<ICommunicationService, WhatsAppCommunicationService>();
            service.AddScoped<ICommunicationService, FacebookCommunicationService>();

            service.AddSingleton<CommunicationManager>();
            return service;
        }
        
        public static T GetService<T>(this IServiceProvider provider, string identifier, bool exertName = false)
        {
            var services = provider.GetServices<T>();

            if (exertName)
                return services.FirstOrDefault(o => o.ToString()?.ToLower() == identifier);
            else
                return services.FirstOrDefault(o => CheckService(o.ToString(), identifier));
        }

        private static bool CheckService(string serviceName, string compareName)
        {
            if (serviceName == null)
            {
                return false;
            }

            return serviceName.ToLower().Contains(compareName.ToLower());
        }
    }
}