using System;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public class TwitterCommunicationService : ICommunicationService
    {
        public void SendMessage(string name)
        {
            Console.WriteLine($"Sending message to {name} via Twitter");
        }
        
        public override string ToString()
        {
            return "twitter";
        }
    }
}