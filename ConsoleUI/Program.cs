using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle done
             * The vehicle class shall have three string properties Year, Make, and Model done
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle>vehicleList = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car1 = new Car() 
            { 
                HasTrunk = true,
                Year = "2022",
                Make = "Toyota",
                Model = "Camry",
            };

            var motocycle1 = new Motorcycle() 
            {
                Year = "2011",
                Make = "Yamaha",
                Model = "YZF-R6",
                HasSideCart = true 
            };

            Vehicle vehicle1 = new Car() 
            {
                Year = "2023",
                Make = "Hyundai",
                Model = "Tucson",
                
            };

            Vehicle vehicle2 = new Motorcycle() 
            {
                Year = "2021",
                Make = "BMW",
                Model = "S1000RR",
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicleList.Add(vehicle1);
            vehicleList.Add(vehicle2);
            vehicleList.Add(car1);
            vehicleList.Add(motocycle1);

            foreach (var vehicle in vehicleList) 
            {
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine();

                vehicle.DriveAbstract();

                vehicle.DriveVirtual();
            }


            // Call each of the drive methods for one car and one motorcycle
            
            #endregion            
            Console.ReadLine();
        }
    }
}
