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


        public Drone()
        {
            this.Name = "Drone";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 400;
            this.IsFlying = false;

            //IRemoteControllable
            this.IsConnected = false;
            this.ControllerIsOn = false;

            //implement UAV engine
            this.Engine = new UAVEngine();
        }


        public string TakeOff()
        {
            if (Engine.IsStarted && IsConnected && ControllerIsOn)
            {
                IsFlying = true;
                return $" > The {Name} is flying";
            }
            else
            {
                return $" > The {Name} isn't ready to fly yet!";
            }
        }

        public void StopEngine()
        {
            if (IsFlying)
            {
                Console.WriteLine($" > Cannot turn off the engine when the {Name} is in the air!");
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
            else Console.WriteLine($"The {this.Name} is already connected");
        }

        public void TurnOnController() 
        { 
            if(!ControllerIsOn) this.ControllerIsOn = true;
            else Console.WriteLine($"The {this.Name}'s controller is already on.");
        }
    }
}
