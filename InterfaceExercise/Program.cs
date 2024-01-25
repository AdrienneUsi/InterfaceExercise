using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var toyota = new Car();
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
            toyota.WheelCount = 4;
           toyota.Year = 2016;
            toyota.CoName = "Toyota Inc.";
            toyota.IsElectric = false;

            var bmw = new Truck();
            bmw.Make = "BMW";
            bmw.Model = "All Black";
            bmw.Year = 2023;
            bmw.WheelCount = 4;
            bmw.BedLength = "6ft";
            bmw.CoName = "BMW Inc.";

            var honda = new SUV();
           honda.Model = "Speedy";
           honda.Make = "Honda";
            honda.Year = 2023;
            honda.WheelCount = 4;
            honda.IsHatchback = true;
            honda.CoName = "Honda Inc.";

            var parkinigLot = new List<IVehicle>() { toyota, bmw, honda };

            foreach (var vehicle in parkinigLot)
            {
                if (vehicle is Car)
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear: {vehicle.Year}\nElectric: {toyota.IsElectric}\n");
                }
                else if (vehicle is Truck)
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear: {vehicle.Year}\nBed Length: {bmw.BedLength}\n");
                }
                else
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear: {vehicle.Year}\nHatchback: {honda.IsHatchback}");
                }
            }

        }
    }
}