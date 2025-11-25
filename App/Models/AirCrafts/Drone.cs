using AerialVehicleApp.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.AirCrafts
{
    public class Drone : AerialVehicle, IRemoteControllable
    {
        //implement IRemoteControllable
        public bool IsConnected { get; set; }
        public bool ControllerIsOn { get; set; }

        public Drone(IEngine engine)
        {
            //this.Name = "Drone";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 400;
            this.IsFlying = false;

            //IRemoteControllable
            this.IsConnected = false;
            this.ControllerIsOn = false;

            //implement 
            this.Engine = engine;
        }

        public Drone() : this(new UAVEngine())
        {

        }

        public void TakeOff()
        {
            if (Engine.IsStarted && IsConnected && ControllerIsOn)
            {
                IsFlying = true;
                Console.WriteLine($" > The {this} is flying");
            }
            else
            {
                Console.WriteLine($" > The {this} isn't ready to fly yet!");
            }
        }

        public void StopEngine()
        {
            if (IsFlying)
            {
                Console.WriteLine($" > Cannot turn off the engine when the {this} is in the air!");
            }
            else
            {
                Engine.Stop();
            }
        }


        //implement IRemoteControllable
        public void Connect() 
        {
            if (!IsConnected) this.IsConnected = true;
            else Console.WriteLine($"The {this} is already connected");
        }

        public void TurnOnController() 
        { 
            if(!ControllerIsOn) this.ControllerIsOn = true;
            else Console.WriteLine($"The {this}'s controller is already on.");
        }
    }
}
