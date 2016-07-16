using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal animal = new Animal("Joe");
            animal.Name = "Steve";
            string response= animal.Eat(5);

            Console.WriteLine(animal.Name + " says "+ response);

            AilurusFulgens red_panda =new AilurusFulgens("Jigglypu");
            Console.WriteLine(red_panda.Eat(4));
            Console.WriteLine(red_panda.Welcome());
            Console.WriteLine(red_panda.Welcome("Joe"));
            Console.WriteLine(red_panda.Name.ToLower());
            
        }
    }
}
