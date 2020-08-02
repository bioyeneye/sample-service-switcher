using System;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public class FacebookCommunicationService : ICommunicationService
    {
        public void SendMessage(string name)
        {
            Console.WriteLine($"Sending message to {name} via Facebook");
        }
    }
}