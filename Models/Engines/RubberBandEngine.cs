using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AerialVehicleApp.Models.Engines
{
    public class RubberBandEngine : Engine, IWindable
    {
        //should the engine wind up, or the toy plane?

        public bool IsWoundUp { get; set; }

        public void StartEngine()
        {
            if (!IsWoundUp)
            {
                Console.WriteLine($" > Cannot start engine, it's not wound up!");
            }
            else
            {
                this.Start();
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
