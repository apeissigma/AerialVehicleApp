using AerialVehicleApp.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace AerialVehicleApp.Models.AirCrafts
{
    public abstract class AerialVehicle : IFlyable
    {
        //protected string Name { get; set; }
       

        //from IFlyable
        public IEngine Engine { get; set; }
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        public bool IsFlying { get; set; }

        public AerialVehicle()
        {
            this.Engine = new JetEngine(); 
        }
        public AerialVehicle(IEngine engine)
        {
            this.Engine = engine; 
        }


        public string About()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"\n========== {this} Information ==========\n");

            sb.Append($" > This {this} has a max altitude of {MaxAltitude} ft. \n");
            sb.Append($" > It's current altitude is {CurrentAltitude} ft. \n");

            //if engine is not started
            if (!Engine.IsStarted)
            {
                sb.Append($" > The {this}'s engine is not started.");
            }
            else
            {
                sb.Append($" > The {this}'s engine is running.");
            }

            return sb.ToString();
        }

        public void FlyUp()
        {
            if (!Engine.IsStarted || !IsFlying)
            {
                WriteLine($" > The {this} is not running yet!");
            }
            else if (CurrentAltitude > MaxAltitude - 1000)
            {
                WriteLine($" > The {this} cannot fly this high!");
            }
            else
            {
                CurrentAltitude += 1000;
            }
        }

        public void FlyUp(int altitude)
        {
            if (!Engine.IsStarted || !IsFlying)
            {
                WriteLine($" > The {this} is not running yet!");
            }
            else if (CurrentAltitude > MaxAltitude - altitude)
            {
                WriteLine($" > The {this} cannot fly this high!");
            }
            else
            {
                CurrentAltitude += altitude;
            }
        }

        public void FlyDown()
        {
            if (!Engine.IsStarted || !IsFlying)
            {
                WriteLine($" > The {this} is not running yet!");
            }
            else if (CurrentAltitude < 1000)
            {
                WriteLine(" > Too low to fly!");
            }
            else
            {
                CurrentAltitude -= 1000;
            }
        }

        public void FlyDown(int altitude)
        {
            if (!Engine.IsStarted || !IsFlying)
            {
                WriteLine($" > The {this} is not running yet!");
            }
            else if (CurrentAltitude < altitude)
            {
                WriteLine(" > You'll crash if you go down this far!");
            }
            else if (CurrentAltitude == altitude) //land
            {
                WriteLine($" > The {this} has landed!");
                CurrentAltitude -= altitude;
                IsFlying = false;
                Engine.IsStarted = false;
            }
            else
            {
                CurrentAltitude -= altitude;
            }
        }
   
        public void TakeOff()
        {
            //Test take off should fail engine isn't started
            if (Engine.IsStarted)
            {
                IsFlying = true;
                Console.WriteLine($" > The {this} is flying");
            }
            else
            {
                Console.WriteLine($" > The {this} can't fly, it's engine is not started!");
            }
        }

        public void StartEngine()
        {
            Engine.Start(); 
        }

        public void StopEngine()
        {
            if (IsFlying)
            {
                WriteLine($" > Cannot turn off the engine when the {this} is in the air!");
            }
            else
            {
                Engine.Stop();
            }
        }


    }
}
