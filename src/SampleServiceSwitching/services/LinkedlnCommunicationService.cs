using System;
using SampleServiceSwitching.services.interfaces;

namespace SampleServiceSwitching.services
{
    public class LinkedLnCommunicationService : ICommunicationService
    {
        public void SendMessage(string name)
        {
            Console.WriteLine($"Sending message to {name} via LinkedLn");
        }
        
        public override string ToString()
        {
            return "linkedln";
        }
    }
}