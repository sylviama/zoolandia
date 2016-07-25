using System;
using Zoolandia;

namespace Zoolandia.Species{

    public class Eevee: Animal, IRainner
    {
        public Eevee(string name):base (name)
            {
                
            }
            public string Noise()
            {
                return "Wooooo.";
            }

            public override int CutenessLevel()
            {
            return 9;
            }

            public int level()
            {
                return 4;
            }

            public int CP()
            {
                return 908;
            }
    }
}