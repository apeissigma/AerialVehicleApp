using AerialVehicleApp.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.AirCrafts
{
    public class ToyPlane : AerialVehicle, IWindable
    {
        //implement IWindable
        public bool IsWoundUp { get; set; }


        public ToyPlane() : base(new RubberBandEngine())
        {
            this.CurrentAltitude = 0;
            this.MaxAltitude = 50;
            this.IsFlying = false;
            this.IsWoundUp = false;
        }

        public ToyPlane(IEngine engine) : base(engine)
        {
            //this.Name = "Toy Plane";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 50;
            this.IsFlying = false;

            //IWindable
            this.IsWoundUp = false;
        }

        public void StartEngine()
        {
            if (!IsWoundUp)
            {
                Console.WriteLine($" > Cannot start engine, it's not wound up!");
            }
            else
            {
                this.Engine.IsStarted = true;
                Console.WriteLine($" > The {this.Engine} started.");
            }
        }

        //fly up in 10 fit increments
        public void FlyUp()
        {
            if (!Engine.IsStarted || !IsFlying)
            {
                Console.WriteLine($" > The {this} is not running yet!");
            }
            else if (CurrentAltitude > MaxAltitude - 10)
            {
                Console.WriteLine($" > The {this} cannot fly this high!");
            }
            else
            {
                CurrentAltitude += 10;
            }
        }

        public void Unwind()
        {
            if (!IsWoundUp)
            {
                Console.WriteLine($" > The engine has already been unwinded!");
            }
            else
            {
                IsWoundUp = false;
            }
        }

        public void WindUp()
        {
            if (IsWoundUp)
            {
                Console.WriteLine($" > The engine is already wound up!");
            }
            else
            {
                IsWoundUp = true;
            }
        }
    }
}
