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
            
            Leoparduspardalis Ocelot = new Leoparduspardalis();
            Ocelot.diet = "other animals and your face";
            Ocelot.furcolor = "spotted and stripes";
            Ocelot.name = "Ocelot";
            Ocelot.height = "3.3 inches";
            
            Ornithorhynchusanatinus Platypus = new Ornithorhynchusanatinus();
            Platypus.diet = "shrimps and other river stuff";
            Platypus.sound = "growling";
            Platypus.name = "Honey Badger";
            Platypus.height = "20 inches";      
            Console.WriteLine($"The Honey Badger is an african animal which diets consist in{HoneyBadger.diet}, described as {HoneyBadger.temper}, his size is around {HoneyBadger.height}");
            Console.WriteLine($"The Ocelot is a Big Cat, his diet consists in {Ocelot.diet}, his fur color is {Ocelot.furcolor}, can grow as much as {Ocelot.height}");
            Console.WriteLine($"The Platypus is a monetreme animal, his diet consist in {Platypus.diet}, make a {Platypus.sound} sound, it can be as large as {Platypus.height}");
        }
    }    
}