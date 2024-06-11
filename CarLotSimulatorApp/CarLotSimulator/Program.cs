using System;

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

            Car car1 = new Car();
            car1.Year = 2017;
            car1.Make = "Land Rover";
            car1.Model = "Discovery";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;
            Car car2 = new Car();
            car2.Year = 2010;
            car2.Make = "JEEP";
            car2.Model = "Wrangler";
            car2.EngineNoise = "Brrrrrrr";
            car2.HonkNoise = "Honk Honk";
            car2.IsDriveable = true;
            Car car3 = new Car();
            car3.Year = 1984;
            car3.Make = "Man";
            car3.Model = "Legs";
            car3.EngineNoise = "Swish";
            car3.HonkNoise = "MEEP MEEP";
            car3.IsDriveable = false;

            Console.WriteLine($"Car 1: {car1.Year} {car1.Make} {car1.Model}");
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            Console.WriteLine($"Car 2: {car2.Year} {car2.Make} {car2.Model}");
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Console.WriteLine($"Car 3: {car3.Year} {car3.Make} {car3.Model}");
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();



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
