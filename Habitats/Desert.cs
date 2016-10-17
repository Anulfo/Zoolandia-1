using System;

namespace Zoolandia.Habitats
{
    public class Desert: Habitat
    {
       public Desert ()
       {
           this.name = "Arid Desert";
           this.humidity = 25;
           this.width = 160;
           this.temp = 86;
       } 

       public string description()
        {
            return $"This is the {this.name}, it has a temperature of {this.temp}F and humidity of {this.humidity}%";
        }
    }
}