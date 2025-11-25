using AerialVehicleApp.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.AirCrafts
{
    public class Helicopter : AerialVehicle, IHoverable
    {
        //implement IHoverable
        public bool IsHovering { get; set; }


        public Helicopter(IEngine engine)
        {
            //this.Name = "Plane";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 10000;
            this.IsFlying = false;

            //IHoverable
            this.IsHovering = false;

            //implement 
            this.Engine = engine;
        }

        public Helicopter() : this(new ReciprocatingEngine())
        {

        }


        public void Hover()
        {
            if (IsFlying)
            {
                IsHovering = true;
                Console.WriteLine($"The {this} is hovering.");
            }
            else Console.WriteLine($"The {this} can't hover if it's not in the air!");
        }
    }
}
