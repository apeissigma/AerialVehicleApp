using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerialVehicleApp.Models;
using AerialVehicleApp.Models.AirCrafts;
using AerialVehicleApp.Models.Engines;
using Ninject.Modules; 

namespace AerialVehicleApp.Models.DI
{
    public class AircraftModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEngine>().To<JetEngine>().WhenInjectedInto<Airplane>();
            this.Bind<IEngine>().To<ReciprocatingEngine>().WhenInjectedInto<Helicopter>();
            this.Bind<IEngine>().To<RubberBandEngine>().WhenInjectedInto<ToyPlane>();
            this.Bind<IEngine>().To<UAVEngine>().WhenInjectedInto<Drone>();

            this.Bind<Airplane>().ToSelf();
            this.Bind<Helicopter>().ToSelf();
            this.Bind<ToyPlane>().ToSelf();
            this.Bind<Drone>().ToSelf();

            this.Bind<IFlyable>().To<Airplane>();
            this.Bind<IEngine>().To<JetEngine>();
        }
    }
}
