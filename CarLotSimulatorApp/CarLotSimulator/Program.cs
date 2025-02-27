using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var carlotOne = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            var carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "F100";
            carOne.Year = 1971;
            carOne.IsDriveable = true;

            carOne.MakeEngineNoise("vroooooom");
            carOne.MakeHonkNoise("honk honk");

            carlotOne.ParkingLot.Add(carOne);


            var carTwo = new Car();
            carTwo.Make = "Kia";
            carTwo.Model = "Sorento";
            carTwo.Year = 2019;
            carTwo.IsDriveable = true;

            carTwo.MakeEngineNoise("prrrrr");
            carTwo.MakeHonkNoise("HONNNNNNNNK");

            carlotOne.ParkingLot.Add(carTwo);

            var carThree = new Car();
            carThree.Make = "Ford";
            carThree.Model = "Bronco";
            carThree.Year = 1989;
            carThree.IsDriveable = false;

            carThree.MakeEngineNoise("WAHHHHHHH");
            carThree.MakeHonkNoise("it is broken");

            carlotOne.ParkingLot.Add(carThree);



            carlotOne.CheckCars();

            Console.Write($" Number of cars created: {CarLot.numberOfCars}");



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
