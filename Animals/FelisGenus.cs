using System;

namespace Zoolandia.Animals
{
    public class Felis: Animal, IRetractileClaws
    {

        public string habitat {get;set;}

        public int lifespan {get; set;}

        public string mainweapon {get; set;}

        public void claw()
        {
           Console.WriteLine($"{this.name} claws its prey to death");
        }
    }
}