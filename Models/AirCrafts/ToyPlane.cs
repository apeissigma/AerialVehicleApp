using AerialVehicleApp.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.AirCrafts
{
    public class ToyPlane : Airplane, IWindable
    {
        //implement IWindable
        public bool IsWoundUp { get; set; }

        public ToyPlane()
        {
            this.Name = "Toy Plane";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 50;
            this.IsFlying = false;

            //IWindable
            this.IsWoundUp = false;

            //implement rubber band engine
            this.Engine = new RubberBandEngine(); 
        }
    }
}
