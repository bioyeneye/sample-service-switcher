using System;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public class WhatsAppCommunicationService : ICommunicationService
    {
        public void SendMessage(string name)
        {
            Console.WriteLine($"Sending message to {name} via WhatsApp");
        }
    }
}