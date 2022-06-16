using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();

            //TODO

            //Create a seperate class file called Car// Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable// Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()// Done
            //The methods should take one string parameter: the respective noise property// Done


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            // dot notation
            var carOne = new Car();
            carOne.Make = "Jeep";
            carOne.Model = "Wrangler";
            carOne.Year = 2024;
            carOne.EngineNoise = "wroom";
            carOne.HonkNoise = "beep";
            carOne.IsDrivable = true;
            carOne.MakeEnginenoise("wroom");
            carOne.MakeHonkNoise("beep");

            //carLot.CarLots.Add(carOne);

            //Object Initializer Syntax
            var carTwo = new Car()
            {
                Make = "Toyota",
                Model = "Highlander",
                Year = 2023,
                EngineNoise = "no noise",
                HonkNoise="beep",
                IsDrivable=true,

            };

            //carLot.CarLots.Add(carTwo);
            


            // Custom Constructor

            var carThree = new Car(2022, "Toyota", "Sienna", "quiet", "moo moo", true);
            
            //carLot.CarLots.Add(carThree);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class Done
            //It should have at least one property: a List of cars Done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        foreach(var car in CarLot.StaticCarLots)

            {
                Console.Write($"{ car.Year} {car.Make} {car.Model}");
                
                Console.WriteLine();
            }


        
        }

    }
}
