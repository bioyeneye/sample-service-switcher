using System;
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
            _communicationService = _serviceProvider.GetService;
        }
        
    }
}