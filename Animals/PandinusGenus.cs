using System;

namespace Zoolandia.Animals
{
    public class Pandinus: Animal
    {
        public string habitat {get;set;}

        public int lifespan {get; set;}

        public Pandinus ()
        {
            this.lifespan = 10;
            this.habitat = null;
        }
    }
}