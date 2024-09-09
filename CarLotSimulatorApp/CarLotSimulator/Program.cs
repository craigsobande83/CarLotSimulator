using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program
            //and as you create a car add the car to the list.

            var lot = new CarLot();

            //Done Create a seperate class file called Car
            // Done Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // Done Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // Done The methods should take one string parameter: the respective noise property


            // Done Now that the Car class is created we can instanciate 3 new cars
            // Done Set the properties for each of the cars
            //*************BONUS*************//

            // Done Set the properties utilizing the 3 different ways we learned about, one way for each car


            var craigsCar = new Car();
            craigsCar.Make = "Ford";
            craigsCar.Model = "Focus";
            craigsCar.Year = 2013;
            craigsCar.EngineNoise = "vroom";
            craigsCar.HonkNoise = "beep";
            craigsCar.IsDrivable = true;

            //add craigCar to the carlot

            lot.Cars.Add(craigsCar);

            var wunmiCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "sssss",
                HonkNoise = "brmmp",
                IsDrivable = true
            };
            // add wunmiCar to the carlot
            lot.Cars.Add(wunmiCar);

            var brettsCar = new Car(2013,"Honda", "Civic","vrrrooom", "vruuuga", true);

            //add brettscar to the carlot
             lot.Cars.Add(brettsCar);

            //Done Call each of the methods for each car

            craigsCar.MakeEngineNoise(craigsCar.EngineNoise);
            wunmiCar.MakeEngineNoise(wunmiCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);
            
            //*************BONUS X 2*************//

            //Done Create a CarLot class


            // Done It should have at least one property: a List of cars
            
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year} Make: {car.Make} Model:{car.Model}");
            }
        }
    }
}
