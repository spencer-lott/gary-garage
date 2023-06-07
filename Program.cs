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
            // Zero fxs = new Zero();
            // Zero fx = new Zero();
            // Tesla modelS = new Tesla();

            // List<IElectricalVehicle> electricVehicles = new List<IElectricalVehicle>() {
            //     fx, fxs, modelS
            // };

            // Console.WriteLine("Electric Vehicles");
            // foreach(??? ev in electricVehicles)
            // {
            //     Console.WriteLine($"{ev.CurrentChargePercentage}");
            // }

            // foreach(??? ev in electricVehicles)
            // {
            //     // This should charge the vehicle to 100%
            //     ev.ChargeBattery();
            // }

            // foreach(??? ev in electricVehicles)
            // {
            //     Console.WriteLine($"{ev.CurrentChargePercentage}");
            // }

            // /***********************************************/

            // Ram ram = new Ram ();
            // Cessna cessna150 = new Cessna ();

            // List<???> gasVehicles = new List<???>() {
            //     ram, cessna150
            // };

            // Console.WriteLine("Gas Vehicles");
            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }
        
            Zero fxs = new Zero();
            fxs.MainColor = "Green";
            
            Tesla modelS = new Tesla();
            modelS.MainColor = "Pearl";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "BArnEy PuRplE";

            Ram sport3500 = new Ram();
            sport3500.MainColor = "Silver";

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine();
            
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine();

            sport3500.Drive();
            sport3500.Turn();
            sport3500.Stop();
            }
        }
    }


