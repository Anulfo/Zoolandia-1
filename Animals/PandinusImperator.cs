using System;

namespace Zoolandia.Animals
{
    public class Pandinusimperator: Pandinus
    {
        public Pandinusimperator()
        {
            this.name = "Imperator Scorpion";
            this.height = "2";
            this.diet = "other insects";
            this.cost = 500;
            this.habitat = "West Africa";
            this.lifespan = 8;
            this.mainweapon = "humongous pincers";
            this.petname = "Pincers";
        }   
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan}, it's main weapon is {this.mainweapon} ";
        }
    }
}