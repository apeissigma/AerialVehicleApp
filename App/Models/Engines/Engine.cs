using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.Engines
{
    public abstract class Engine : IEngine
    {
        //from IEngine
        public bool IsStarted { get; set; }

        public Engine()
        {
            this.IsStarted = false;
        }

        //from IEngine
        public void Start()
        {
            if (IsStarted)
            {
                Console.WriteLine($" > The {this} is already running!"); 
            }
            else
            {
                IsStarted = true;
                Console.WriteLine($" > The {this} started.");
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
