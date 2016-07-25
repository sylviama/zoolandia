using System;
using Zoolandia.Species;

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
            Eevee sylvisEevee= new Eevee("Eve");
            Console.WriteLine(sylvisEevee.level());
            
        }
    }
}
