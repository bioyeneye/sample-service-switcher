using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public class CommunicationManager
    {
        private IServiceProvider _serviceProvider;
        private ICommunicationService _communicationService;

        public CommunicationManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public void Send(string name, string communicationChannel)
        {
            var service = _serviceProvider
                .GetService<ICommunicationService>(communicationChannel);

            if (service == null)
            {
                Console.WriteLine("Error can not find services");
                return;
            }
            
            service.SendMessage(name);
        }
    }
}