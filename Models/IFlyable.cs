using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models
{
    public interface IFlyable
    {
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        public bool IsFlying { get; set; }

        public void FlyUp() { }
        public void FlyDown() { }
        public void TakeOff() { }
        public void StartEngine() { }
        public void StopEngine() { }
    }
}
