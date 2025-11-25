using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models
{
    public interface IRemoteControllable
    {
        public bool IsConnected { get; set; }
        public bool ControllerIsOn { get; set; }

        public void Connect() { }
        public void TurnOnController() { }
    }
}
