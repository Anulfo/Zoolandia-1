using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name {get; set;}
        public string height {get; set;}
        public string diet {get; set;}
        public int cost {get; set;}

        public string petname {get; set;}
        public virtual string description()
        {
            return $"is a {this.name} can grow as long as {this.height}, his diet consists in {this.diet}, and has a cost of {this.cost}$ in the black market";
        }
    }
}