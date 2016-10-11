using System;

namespace Zoolandia.Animals
{
    public class Ranaaurora: Rana
    {
        public Ranaaurora() 
        {
            this.name = "Northern Red Legged Frog";
            this.height = "2 inches";
            this.diet = "insects";
            this.cost = 15000;
            this.habitat = "North America";
            this.lifespan = 5;
            this.mainweapon = "Projectile Tongue";
            this.petname = "Wrinkly";
            this.genus = new Genus("Rana");
            this.species = new Species("aurora");
        }
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan} years old, it's main weapon is {this.mainweapon}. It's scientific name is {this.genus.genusname} {this.species.speciename}";
        }
    }
}