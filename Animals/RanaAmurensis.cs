using System;

namespace Zoolandia.Animals
{
    public class Ranaamurensis: Rana
    {
        public Ranaamurensis() 
        {
            this.name = "Siberian Wood Frog";
            this.height = "4 inches";
            this.diet = "Beattles";
            this.cost = 15000;
            this.habitat = "Northern Asia";
            this.lifespan = 3;
            this.mainweapon = "Hibernation";
            this.petname = "Wrinkly";
            this.genus = new Genus("Rana");
            this.species = new Species("amurensis");
        }
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan} years old, it's main weapon is {this.mainweapon}. It's scientific name is {this.genus.genusname} {this.species.speciename}";
        }
    }
}