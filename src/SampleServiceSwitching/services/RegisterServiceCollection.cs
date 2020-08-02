using Microsoft.Extensions.DependencyInjection;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public static class RegisterServiceCollection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service)
        {
            service.AddTransient<ICommunicationService, TwitterCommunicationService>();
            service.AddTransient<ICommunicationService, LinkedLnCommunicationService>();
            service.AddTransient<ICommunicationService, WhatsAppCommunicationService>();
            service.AddTransient<ICommunicationService, FacebookCommunicationService>();

            service.AddSingleton<CommunicationManager>();
            return service;
        }
    }
}