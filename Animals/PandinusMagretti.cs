using System;

namespace Zoolandia.Animals
{
    public class Pandinusmagretti: Pandinus, ISting
    {
         public void sting()
        {
            Console.Write($"This animal has venomous sting\n");
        }
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
            this.genus = new Genus("Pandinus");
            this.species = new Species("magretti");
        }   
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan} years old, it's main weapon is {this.mainweapon}. It's scientific name is {this.genus.genusname} {this.species.speciename}";
        }  
    }
}