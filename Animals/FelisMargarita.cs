using System;

namespace Zoolandia.Animals
{
    public class Felismargarita: Felis
    {
        public Felismargarita() 
        {
            this.name = "Sand Cat";
            this.height = "2";
            this.diet = "Small Rodents";
            this.cost = 15000;
            this.habitat = "North Africa";
            this.lifespan = 13;
            this.mainweapon = "Hard Bite";
            this.petname = "Whiskers";
            this.genus = new Genus("Felis");
            this.species = new Species("margarita");
        }

        public Felismargarita(int cost, string petname)
        {
            this.cost = cost;
            this.petname = petname;
        }
        
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan} years old, it's main weapon is {this.mainweapon}. It's scientific name is {this.genus.genusname} {this.species.speciename}";
        }
    }
}