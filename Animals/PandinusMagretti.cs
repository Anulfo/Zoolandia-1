using System;

namespace Zoolandia.Animals
{
    public class Pandinusmagretti: Pandinus
    {
         public Pandinusmagretti()
        {
            this.name = "Ethiopian Scorpion";
            this.height = "1";
            this.diet = "other insects";
            this.cost = 1000;
            this.habitat = "Ethiopia";
            this.lifespan = 10;
            this.mainweapon = "Stinger";
            this.petname = "Sting";
        }   
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan}, it's main weapon is {this.mainweapon} ";
        }
    }
}