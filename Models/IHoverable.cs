using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleApp.Models
{
    public interface IHoverable
    {
        public bool IsHovering { get; set; }

        public void Hover() { }
    }
}
