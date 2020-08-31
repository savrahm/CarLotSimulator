using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Xml.Schema;

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
            //DONE (but I ended up taking out method perameters)


            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //DONE

            var inventory = new List<CarLotSimulator.Car>();

            var sweetVintageRides = new CarLot(inventory);

            var car1 = new Car(1966,"Dodge","Charger","vroorooooom", "beepbeep!", true);
            inventory.Add(car1);
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            
            var car2 = new Car();
            car2.Year = 1956;
            car2.Make = "Mercedes";
            car2.Model = "SL 300 Gullwing";
            car2.EngineNoise = "hhhhrrrrraaaarrrrrrhhhhh";
            car2.HonkNoise = "HONK";
            car2.IsDriveable = true;
            inventory.Add(car2);
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            var car3 = new Car()
            {
                Year = 1952,
                Make = "Rolls-Royce",
                Model = "Silver Dawn",
                EngineNoise = "grrrmmmbbgrrrmmmmb",
                HonkNoise = "aooogah!!",
                IsDriveable = true
            };
            inventory.Add(car3);
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            foreach(CarLotSimulator.Car car in inventory)
            {

                Console.WriteLine($"Currently available: {car.Year} {car.Make} {car.Model}.");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //DONE
        }
    }
}
