using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args) 
        {   

            
            string petname=args.Length > 0?args[0]: null;
            if (petname == null)
            {
            Mellivoracapensis HoneyBadger = new Mellivoracapensis();
            Console.WriteLine (HoneyBadger.description());
            }
            else if (petname != String.Empty)
            {
            Mellivoracapensis HoneyBadger = new Mellivoracapensis(petname);
            Console.WriteLine (HoneyBadger.description());
            }

            
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

            Felismargarita SandCat = new Felismargarita();
            Console.WriteLine (SandCat.description());

            Felisnegripes BlackCat = new Felisnegripes();
            Console.WriteLine (BlackCat.description());
        }
    }    
}