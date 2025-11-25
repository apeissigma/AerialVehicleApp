using static System.Console;
using AerialVehicleApp.Models.DI;
using AerialVehicleApp.Models.AirCrafts;
using Ninject;
using AerialVehicleApp.Models;

namespace AerialVehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Tester t = new Tester();
            //t.Test();
            IKernel kernel = new StandardKernel(new AircraftModule());

            IFlyable NPlane = kernel.Get<Airplane>();
            NPlane.StartEngine();
            WriteLine(NPlane.About());

            IFlyable NDrone = kernel.Get<Drone>();
            WriteLine(NDrone.About());

            IFlyable NHelicopter = kernel.Get<Helicopter>();
            WriteLine(NHelicopter.About());

            IFlyable NToyPlane = kernel.Get<ToyPlane>();
            WriteLine(NToyPlane.About());
        }

    }
}
