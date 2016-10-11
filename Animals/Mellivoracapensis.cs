using System;
namespace Zoolandia.Animals
{
    public class Mellivoracapensis: Animal
    {
        public string temper {get; set;}

        public Mellivoracapensis ()
        {
            petname = "Stripe";
            cost = 7000;
            diet = "whatever comes across his way";
            temper = "vicious bastard";
            name = " Honey Badger";
            height = " 50 inches ";
        }
        public Mellivoracapensis (string petname)
        {
            this.petname = petname;
        }
        public Mellivoracapensis (int cost)
        {
            this.cost = cost;
        }
        public Mellivoracapensis (int cost, string petname)
        {
            this.petname = petname;
            this.cost = cost;
        }
        public override string description()
        {
            return $"This is {this.petname} \n{base.description()}, also is described as a {this.temper}";
        }
    }
}