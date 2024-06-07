using System;
using System.Globalization;

namespace TP_Test1_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question1 [20 Marks]
            Compile the Vehicle class provided together with the question paper. Write a program that performs
            the following functions:
            1.1.Declare an array of five vehicle objects (2)-*/
            Vehicle[] vehicles = populateVehicles();

            searchMake(vehicles);



            /*1.4.Count the vehicles in the array that are of the same make. (5)
            1.5.Display all the vehicle records in the array (the content of the array) (3)*/
        }
        public static void countCars(Vehicle[] vehicles)
        {
            bool isMake = false;
            string make;
            /*
           1.3.Allow the user to search for the vehicle in the array by make, e.g Toyota. If found, display the
           details of the vehicle. (5)*/
            Console.WriteLine("Enter a car make to search");
            make = Console.ReadLine();

            int len = vehicles.Length;

            for (int k = 0; k < len; k++)
            {
                if (vehicles[k].getMake() == make)
                {
                    Console.WriteLine("Car Make: " + vehicles[k].getMake());
                    Console.WriteLine("Car Release Year: " + vehicles[k].getYear());
                    Console.WriteLine("Car Color: " + vehicles[k].getColor());
                    isMake = true;
                    break;
                }

            }
            if (isMake == false)
            {
                Console.WriteLine("Car Make Not Found...");
            }


        }
        public static void searchMake(Vehicle[] vehicles)
        {
            bool isMake = false;
            string make;
            /*
           1.3.Allow the user to search for the vehicle in the array by make, e.g Toyota. If found, display the
           details of the vehicle. (5)*/
            Console.WriteLine("Enter a car make to search");
            make = Console.ReadLine();
            
            int len = vehicles.Length;

            for (int k = 0; k < len; k++)
            {
                if (vehicles[k].getMake() == make)
                {
                    Console.WriteLine("Car Make: " + vehicles[k].getMake());
                    Console.WriteLine("Car Release Year: " + vehicles[k].getYear());
                    Console.WriteLine("Car Color: " + vehicles[k].getColor());
                    isMake = true;
                    break;
                }

            }
            if(isMake == false)
            {
                Console.WriteLine("Car Make Not Found...");
            }

        }
        public static Vehicle[] populateVehicles() 
        {
            /*1.2.Prompt the user for the vehicle details and load into the array declared above. (5) */
            Vehicle[] vehicles = new Vehicle[5];
            string make;
            string year;
            string color;
            int len = vehicles.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter car make");
                make = Console.ReadLine();
                Console.WriteLine("Enter car color");
                color = Console.ReadLine();
                Console.WriteLine("Enter car year release date");
                year = Console.ReadLine();

                vehicles[i] = new Vehicle(make, year, color);
            }
            return vehicles;
        }
    }
    internal class Vehicle
    {
        private string make;
        private string year;
        private string color;

        public Vehicle(string make, string year, string color)
        {
            this.color=color;
            this.year=year;     
            this.make=make;
        }
        public void setMake(string make) { this.make = make; }

        public string getMake() { return make; }
        public void setYear(string year)
        {
            this.year = year;
        }
        public string getYear()
        {
            return year;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color) { this.color = color; }
    }
}