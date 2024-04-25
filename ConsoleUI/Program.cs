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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Done - Create an abstract class called Vehicle
             * Done - The vehicle class shall have three string properties: Year, Make, and Model
             * Done - Set the defaults of the properties to something generic in the Vehicle class
             * Done - Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Done - Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Done - Provide the implementations for the abstract methods
             * Done - Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            Car fusion = new Car() { HasTrunk = true, Make = "Ford", Model = "Fusion", Year = 2018 };
            var Motorcycle = new Motercycle() { HasSidecart = true, Make = "HD", Model = "Chopper", Year = 2010 };

            Vehicle sedan = new Car() { Make = "Honda", Model = "Civic", Year = 2020 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Porshe", Model = "911", Year = 2016 };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
              vehicles.Add(fusion);
              vehicles.Add(Motorcycle);
              vehicles.Add(sedan);
              vehicles.Add(sport);

             foreach (var veh in vehicles) 
             {  
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveVirtual();
                Console.WriteLine("-------------------------------");
             }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
