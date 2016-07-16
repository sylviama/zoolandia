using System;

namespace Zoolandia
{

    public class AilurusFulgens : Animal
    {
        public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(3);//parent's
            return animalEat + "Nom nom nom";
        }

        public string Welcome (string name)
        {
            this.Name=name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, "+ this.Name;
        }
    }


}