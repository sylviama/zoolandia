using System;

namespace Zoolandia
{

    public class Animal
    {
        //animal constructor
        public Animal(string name)
        {
            this.Name =name;
        }

        // public string Name{get;set;}
        private string _name= "Pikachu";
        public string Name{
            get{return _name;}
            set{_name=value;}
        }

        public virtual string Eat(int numberOfFoodz)
        {
            return "Yum!";
        }
    }
}