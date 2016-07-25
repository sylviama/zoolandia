using System;
using System.Collections.Generic;
using Zoolandia.Species;

namespace Zoolandia.Habitat
{
    public class Habitat
    {
        public Habitat(string name)
        {
            this.Name= name;
        }

        public List<Animal> inhabitants = new List<Animal>();
        public string Name {get; set;}
        
    }
}