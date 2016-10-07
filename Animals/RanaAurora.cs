using System;

namespace Zoolandia.Animals
{
    public class Ranaaurora: Rana
    {
        public Ranaaurora() 
        {
            this.name = "Northern Red Legged Frog";
            this.height = "2";
            this.diet = "Beattles";
            this.cost = 15000;
            this.habitat = "North Africa";
            this.lifespan = 5;
            this.mainweapon = "Projectile Tongue";
            this.petname = "Wrinkly";
        }
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, it's natural habitat is {this.habitat}, can live till {this.lifespan}, it's main weapon is {this.mainweapon} ";
        }
    }
}