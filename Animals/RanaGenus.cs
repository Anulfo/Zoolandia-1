using System;

namespace Zoolandia.Animals
{
    public class Rana: Animal
    {
        public string habitat {get;set;}

        public int lifespan {get; set;}

        public Rana ()
        {
            this.lifespan = 10;
            this.habitat = null;
        }
    }
}