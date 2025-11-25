using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models
{
    public interface IEngine
    {
        public bool IsStarted { get; set; }
        public void Start() { }
        public void Stop() { }
    }
}
