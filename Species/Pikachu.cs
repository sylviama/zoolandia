using System;
using Zoolandia;

namespace Zoolandia.Species{

    public class Pikachu: Animal
    {
        public Pikachu(string name):base (name)
        {

        }
        public string Noise()
        {
            return "Pika pika.";
        }

        public override int CutenessLevel()
        {
            return 10;
        }
    }
    
}