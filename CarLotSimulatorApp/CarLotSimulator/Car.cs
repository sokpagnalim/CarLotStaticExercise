using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //TODO

        //Create a seperate class file called Car//Done
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable //Done
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()// Done
        //The methods should take one string parameter: the respective noise property// Done

        public Car()//Default Constructor
        {
            CarLot.numberOfCars++;
            CarLot.StaticCarLots.Add(this);
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;

            CarLot.numberOfCars++;
            CarLot.StaticCarLots.Add(this);
        }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEnginenoise(string engineNoise)
        {
            Console.WriteLine($"The engine goes {engineNoise}.");
        }
        public void MakeHonkNoise(string honkNoise) 
        {
            Console.WriteLine($"The honkNoise goes {honkNoise}.");
        }
    }


}
