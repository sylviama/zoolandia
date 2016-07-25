using System;
using Zoolandia.Species;
using Zoolandia.Habitat;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //animal output
            Animal animal = new Animal("Joe");
            animal.Name = "Steve";
            string response= animal.Eat(5);

            Console.WriteLine(animal.Name + " says "+ response);


            //red_panda output
            AilurusFulgens red_panda =new AilurusFulgens("Jigglypu");
            Console.WriteLine(red_panda.Eat(4));
            Console.WriteLine(red_panda.Welcome());
            Console.WriteLine(red_panda.Welcome("Joe"));
            Console.WriteLine(red_panda.Name.ToLower());

            //Pikachu output
            Pikachu sylviasPika = new Pikachu("Pika");
            Console.WriteLine(sylviasPika.Noise());
            
            //Kakuna
            Kakuna sylviaKakuna = new Kakuna("Kak");
            Console.WriteLine(sylviaKakuna.Noise());

            //Eevee
            Eevee sylviaEevee= new Eevee("Eve");
            Console.WriteLine(sylviaEevee.level());



            //Habitat
            Jungle my_jungle = new Jungle("my jungle");
            Ocean my_ocean = new Ocean("my ocean");

            //Jungle Animals
            my_jungle.inhabitants.Add(sylviaEevee);
            my_jungle.inhabitants.Add(sylviaKakuna);

            Console.WriteLine("Jungle Animals are: ");
            foreach(var jungle in my_jungle.inhabitants)
            {
                Console.WriteLine(jungle.Name);
            }

            //Ocean Animals
            my_ocean.inhabitants.Add(sylviasPika);
            my_ocean.inhabitants.Add(red_panda);

            Console.WriteLine ("Ocean Animals are: ");
            foreach (var ocean in my_ocean.inhabitants)
            {
                Console.WriteLine(ocean.Name);
            }
            
            
        }
    }
}
