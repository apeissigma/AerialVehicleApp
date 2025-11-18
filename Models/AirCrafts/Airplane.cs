using AerialVehicleApp.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models.AirCrafts
{
    public class Airplane : AerialVehicle
    {
        public Airplane()
        {
            this.Name = "Plane";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 41000;
            this.IsFlying = false;

            //implement jet engine
            this.Engine = new JetEngine();
        }

        public Airplane(JetEngine engine)
        {
            this.Name = "Plane";
            this.CurrentAltitude = 0;
            this.MaxAltitude = 41000;
            this.IsFlying = false;

            //implement 
            this.Engine = engine;
        }
    }
}
