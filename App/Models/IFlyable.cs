using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models
{
    public interface IFlyable : IAboutable
    {
        public IEngine Engine { get; set; }
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        public bool IsFlying { get; set; }

        //from IAboutable
        public string About() => "";

        public void FlyUp() { }
        public void FlyUp(int altitude) { }
        public void FlyDown() { }
        public void FlyDown(int altitude) { }
        public void TakeOff() { }
        public void StartEngine() { }
        public void StopEngine() { }
    }
}
