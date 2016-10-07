using System;

namespace Zoolandia.Animals
{
    public class Felisnegripes: Felis
    {
        public Felisnegripes() 
        {
            this.name = "Black Footed Cat";
            this.height = "2";
            this.diet = "Hare";
            this.cost = 50000;
            this.habitat = "South Africa";
            this.lifespan = 10;
            this.mainweapon = "Stalk Hunter";
            this.petname = "FurFur";
        }
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan}, it's main weapon is {this.mainweapon} ";
        }
    }
}