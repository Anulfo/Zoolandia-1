using System;

namespace Zoolandia.Animals
{
    public class Rana: Animal, IAmphibious
    {
        public void amphibious()
        {
            Console.Write($"This animal is able to breath under the water and over it.\n");
        }
        public string habitat {get;set;}

        public int lifespan {get; set;}

        public string mainweapon {get; set;}
        public Rana ()
        {
            this.lifespan = 10;
            this.habitat = null;
            this.mainweapon = null;
        }
    }
}