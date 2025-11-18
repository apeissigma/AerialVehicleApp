using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.Engines
{
    public class Engine : IEngine, IAboutable
    {
        //from IEngine
        public bool IsStarted { get; set; }

        //constructor injection
        public Engine()
        {
            IsStarted = false; 
        }

        //from IAboutable
        public void About()
        {

        }

        //from IEngine
        public void Start()
        {
            if (IsStarted)
            {
                Console.WriteLine(" > The engine is already running!"); 
            }
            else
            {
                IsStarted = true;
                Console.WriteLine(" > The engine started.");
            }
        }

        //from IEngine
        public void Stop()
        {
            if (!IsStarted)
            {
                Console.WriteLine(" > The engine isn't running!");
            }
            else
            {
                IsStarted = false;
                Console.WriteLine(" > The engine stopped.");
            }
        }
    }
}
