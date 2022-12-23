using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {





            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();
            

            var firstCar = new Car();
            firstCar.Year = 2020;
            firstCar.Make = "Chevrolet";
            firstCar.Model = "Corvette";
            firstCar.EngineNoise = "Vroom";
            firstCar.HonkNoise = "beep";
            firstCar.isDriveable= true;
            

            var secondCar = new Car();
            secondCar.Year = 2015;
            secondCar.Make = "Ford";
            secondCar.Model = "F-150";
            secondCar.EngineNoise = "RumRum";
            secondCar.HonkNoise = "BEEP";
            secondCar.isDriveable= true;

            var thirdCar = new Car();
            thirdCar.Year = 2000;
            thirdCar.Make = "Ford";
            thirdCar.Model = "Ranger";
            thirdCar.EngineNoise = "Scoobydoobop";
            thirdCar.HonkNoise = "OongaBoonga";
            thirdCar.isDriveable = false;

            //Call Methods
            Console.WriteLine("Engine Noises:");
            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Honk Noises:");
            firstCar.MakeHonkNoise(firstCar.HonkNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);
            thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            Console.WriteLine($"The number of cars is: {CarLot.numberOfCars}");



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
