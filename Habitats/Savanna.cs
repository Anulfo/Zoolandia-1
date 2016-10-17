using System;

namespace Zoolandia.Habitats
{
    public class Savanna: Habitat, ITransportation
    {
        public void ITransportation()
        {
            Console.WriteLine($"This enviroment has a Jeep to do the appropiate maintenance");
        }
        public Savanna ()
        {
            this.name = "African Savanna";
            this.humidity = 85;
            this.width = 1000;
            this.temp = 80;
        }
         public string description()
        {
            return $"This is the {this.name}, it has a temperature of {this.temp}F and humidity of {this.humidity}%";
        }
    }
}