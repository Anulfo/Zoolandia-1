using System;
using Zoolandia.Animals;
using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Habitat
    {
        public string name {get; set;}
        public int humidity {get; set;}
        public int width {get; set;}
        public int volume {get; set;}
        public int temp {get; set;}

        public List<Animal> inhabitants = new List<Animal>();
    }

}