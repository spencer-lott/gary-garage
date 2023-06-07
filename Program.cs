using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            fxs.CurrentChargePercentage = "78";
            Zero fx = new Zero();
            fx.CurrentChargePercentage = "29";
            Tesla modelS = new Tesla();
            modelS.CurrentChargePercentage = "3";

            List<IElectricalVehicle> electricVehicles = new List<IElectricalVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricalVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}/100");
            }

            foreach(IElectricalVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricalVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Current charge: {ev.CurrentChargePercentage}/100");
            }

            /***********************************************/

            Ram ram = new Ram ();
            ram.CurrentTankPercentage = "25";
            Cessna cessna150 = new Cessna ();
            cessna150.CurrentTankPercentage = "55";

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine();
            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}/100");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Fill level: {gv.CurrentTankPercentage}/100");
            }
        
            }
        }
    }


            // Zero fxs = new Zero();
            // fxs.MainColor = "Green";
            
            // Tesla modelS = new Tesla();
            // modelS.MainColor = "Pearl";

            // Cessna mx410 = new Cessna();
            // mx410.MainColor = "BArnEy PuRplE";

            // Ram sport3500 = new Ram();
            // sport3500.MainColor = "Silver";

            // fxs.Drive();
            // fxs.Turn();
            // fxs.Stop();
            // Console.WriteLine();

            // modelS.Drive();
            // modelS.Turn();
            // modelS.Stop();
            // Console.WriteLine();
            
            // mx410.Drive();
            // mx410.Turn();
            // mx410.Stop();
            // Console.WriteLine();

            // sport3500.Drive();
            // sport3500.Turn();
            // sport3500.Stop();
