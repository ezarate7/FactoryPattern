using FactoryPattern;
using System;
using System.Collections.Generic;



Console.WriteLine("Enter the amount of tires for the vehicle you would like to create:");
string input  = Console.ReadLine();

IVehicle vehicle1 = VehicleFactory.GetVehicle(input);

vehicle1.Drive();