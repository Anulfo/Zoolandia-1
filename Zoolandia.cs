using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args) 
        {   
            Mellivoracapensis HoneyBadger = new Mellivoracapensis();
            HoneyBadger.diet = "whatever comes across his way";
            HoneyBadger.temper = "vicious bastard";
            HoneyBadger.name = " Honey Badger";
            HoneyBadger.height = " 50 inches ";
            HoneyBadger.cost = 7000;
            Console.WriteLine (HoneyBadger.description());

            Mellivoracapensis MyBadger = new Mellivoracapensis("Anulfo");
            MyBadger.diet = "fresh baby Koalas";
            MyBadger.temper = "always hungry bastard";
            MyBadger.name = "Honey Badger";
            MyBadger.height = " 3 feet ";
            MyBadger.cost = 3500;
            Console.WriteLine (MyBadger.description());

            Mellivoracapensis ExpensiveBadger = new Mellivoracapensis(500000);
            ExpensiveBadger.diet = "fresh baby Koalas";
            ExpensiveBadger.temper = "always hungry bastard";
            ExpensiveBadger.name = "Honey Badger";
            ExpensiveBadger.height = " 3 feet ";
            Console.WriteLine (ExpensiveBadger.description());

            Mellivoracapensis CustomBadger = new Mellivoracapensis(10, "Fluffy");
            CustomBadger.diet = "fresh baby Koalas";
            CustomBadger.temper = "always hungry bastard";
            CustomBadger.name = "Honey Badger";
            CustomBadger.height = " 3 feet ";
            Console.WriteLine (CustomBadger.description());
            
            Leoparduspardalis Ocelot = new Leoparduspardalis();
            Ocelot.diet = "other animals and your face";
            Ocelot.furcolor = "spotted and stripes";
            Ocelot.name = "Ocelot";
            Ocelot.height = "3.3 feet";
            Ocelot.cost = 900000;
            Console.WriteLine (Ocelot.description());
            
            Ornithorhynchusanatinus Platypus = new Ornithorhynchusanatinus();
            Platypus.diet = "shrimps and other river stuff";
            Platypus.sound = "growling";
            Platypus.name = "Platypus";
            Platypus.height = "20 inches";    
            Platypus.cost = 15000;
            Console.WriteLine (Platypus.description());
            
        }
    }    
}