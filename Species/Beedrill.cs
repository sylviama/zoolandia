using System;

namespace Zoolandia.Species{

    public class Beedrill: Animal
    {
        public Beedrill(string name):base (name)
        {
                
        }
            public string Noise()
            {
                return "Wooooo.";
            }

            public override int CutenessLevel()
            {
            return 6;
            }
    }

    public class Kakuna : Beedrill
    {
        public Kakuna(string name): base(name)
        {}
    }

}