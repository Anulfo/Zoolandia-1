using System;
using Zoolandia.Animals;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args) 
        {   

            
            // string petname=args.Length > 0?args[0]: null;
            // if (petname == null)
            // {
            // Mellivoracapensis HoneyBadger = new Mellivoracapensis();
            // Console.WriteLine (HoneyBadger.description());
            // }
            // else if (petname != String.Empty)
            // {
            // Mellivoracapensis HoneyBadger = new Mellivoracapensis(petname);
            // Console.WriteLine (HoneyBadger.description());
            // }

            
            // Leoparduspardalis Ocelot = new Leoparduspardalis();
            // Ocelot.diet = "other animals and your face";
            // Ocelot.furcolor = "spotted and stripes";
            // Ocelot.name = "Ocelot";
            // Ocelot.height = "3.3 feet";
            // Ocelot.cost = 900000;
            // Console.WriteLine (Ocelot.description());
            
            // Ornithorhynchusanatinus Platypus = new Ornithorhynchusanatinus();
            // Platypus.diet = "shrimps and other river stuff";
            // Platypus.sound = "growling";
            // Platypus.name = "Platypus";
            // Platypus.height = "20 inches";    
            // Platypus.cost = 15000;
            // Console.WriteLine (Platypus.description());

            // Felismargarita SandCat = new Felismargarita();
            // Console.WriteLine (SandCat.description());
            // SandCat.claw();

            // Felisnegripes BlackCat = new Felisnegripes();
            // Console.WriteLine (BlackCat.description());
            // BlackCat.claw();
            
            // Pandinusimperator ImperatorScorpion = new Pandinusimperator();
            // Console.WriteLine (ImperatorScorpion.description());
            // ImperatorScorpion.UVGlow();
            
            // Pandinusmagretti EthiopianScorpion = new Pandinusmagretti();
            // Console.WriteLine (EthiopianScorpion.description());
            // EthiopianScorpion.sting();
            
            Ranaaurora RedLeggedFrog = new Ranaaurora();
            // Console.WriteLine (RedLeggedFrog.description());
            // RedLeggedFrog.amphibious();
            
            Ranaamurensis SiberianFrog = new Ranaamurensis();
            // Console.WriteLine (SiberianFrog.description());
            
            Swamp frogland = new Swamp();
            frogland.inhabitants.Add(RedLeggedFrog);
            frogland.inhabitants.Add(SiberianFrog);
            Console.WriteLine($"In Zoolandia we have a {frogland.name}\n{frogland.description()}");
            frogland.enviroregulator();
            foreach (Animal animal in frogland.inhabitants)
            {
                Console.WriteLine($"Here we have {animal.genus.genusname}{animal.species.speciename} better known as {animal.name}");
            }
        }
    }    
}