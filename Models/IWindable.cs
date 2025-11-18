using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models
{
    public interface IWindable
    {
        public bool IsWoundUp { get; set; }

        public void Unwind() { }
        public void WindUp() { }
    }
}
