using System;
using System.Collections.Generic;
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal("Koala",10, 1));
            animalList.Add(new Animal("Fox", 20, 25));
            animalList.Add(new Animal("Tiger", 100, 30));
            animalList.Add(new Animal("Pantera", 35, 60));
            animalList.Add(new Animal("Mosquito", 0.001, 1));
            animalList.Add(new Animal("Frog", 2, 10));
            animalList.Add(new Animal("Crazy Frog", 2, 25));
            foreach(var Animal in animalList)
            {
                Console.WriteLine(animalList.ToString());
            }

        }
    }
}
