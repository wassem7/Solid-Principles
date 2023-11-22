using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{

    interface IRobot
    {
        void ShutDown();
        void BootUpSound();
    }

    interface IAritificialIntelligence
    {
        void StartAiAssistant();
    }

    class IndustrialRobot : IRobot, IAritificialIntelligence
    {
        public void ShutDown()
        {
            Console.WriteLine("Shutting down....");
        }

        public void StartAiAssistant()
        {
            Console.WriteLine("AI Assistant starting...");
        }
        public void BootUpSound()
        {
            Console.WriteLine("Beep beep");
        }
    }
    
}
