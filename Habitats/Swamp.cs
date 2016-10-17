using System;

namespace Zoolandia.Habitats
{
    public class Swamp: Habitat, ITempHumidityCtrl
    {
        public void enviroregulator()
        {
            Console.WriteLine($"This enviroment has a system to preserve humidity and temperature");
        }

        public Swamp ()
        {
        this.name = "Frog Terrarium";
        this.humidity = 95;
        this.width = 8;
        this.volume = 20;
        this.temp = 75;
        }
        public string description()
        {
            return $"This is the {this.name}, it has volume of {this.volume} gallons, a temperature of {this.temp}F and humidity of {this.humidity}%";
        }
    }
}