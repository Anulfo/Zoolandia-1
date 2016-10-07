using System;

namespace Zoolandia.Animals
{
    public class Felis: Animal
    {
        public string habitat {get;set;}

        public int lifespan {get; set;}

        public bool nightvision {get; set;}

        public Felis ()
        {
            this.lifespan = 10;
            this.habitat = null;
            this.nightvision = true;
        }
    }
}