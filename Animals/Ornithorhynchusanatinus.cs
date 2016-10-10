using System;

namespace Zoolandia.Animals 
{
    public class Ornithorhynchusanatinus: Animal
    {
        public string sound {get; set;}

        public string petname {get;set;}
        public Ornithorhynchusanatinus ()
        {
            this.petname = "Duck Duck";
        }
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, surprisingly it makes a {this.sound} sound";
        }
    }
}