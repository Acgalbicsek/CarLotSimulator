using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {   
        
        
        static void Main(string[] args)
        {
            var lot = new CarLot();
            


            Car myCar = new Car();
            myCar.Make = "Volkswagon";
            myCar.Model = "Corrado";
            myCar.Year = 1988;
            myCar.EngineNoise = "Sounds like a rabbit in distress";
            myCar.HonkNoise = "Goose Honk";
            myCar.IsDriveable = "Slowly but surely";

            lot.Cars.Add(myCar);

            var Ford = new Car()
            {
                Make = "Ford",
                Model = "Bronco",
                Year = 1989,
                EngineNoise = "The stampede of wild horses",
                HonkNoise = "LOUD",
                IsDriveable = "awww YYEAAAHHH",


            };
            lot.Cars.Add(Ford);

            var amc = new Car()
            {
                Make = "AMC",
                Model = "Eagle",
                Year = 1981,
                EngineNoise = "vroom vroom",
                HonkNoise = "Look for hand gesture out the window",
                IsDriveable = "Only driveable in Wisconsin",

            };
            lot.Cars.Add(amc);

           
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);
            
            Ford.MakeEngineNoise(Ford.EngineNoise);
            Ford.MakeHonkNoise(Ford.HonkNoise);
            
            amc.MakeEngineNoise(amc.EngineNoise);
            amc.MakeHonkNoise(amc.HonkNoise);



            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} IsDriveable: {car.IsDriveable}");
            }

            
            

            
            //TODO

            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property


            // DONE Now that the Car class is created we can instanciate 3 new cars
            // DONE Set the properties for each of the cars
            // Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
