using System;
using System.Threading.Tasks;
using SampleServiceSwitching.services;

namespace SampleServiceSwitching
{
    public class App
    {
        private CommunicationManager _communicationManager;
        public App(CommunicationManager communicationManager)
        {
            _communicationManager = communicationManager;
        }

        public async Task RunApp()
        {
            _communicationManager.Send("bolaji", "facebook");

            Console.WriteLine();
        }
    }
}