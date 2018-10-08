using System;
namespace Exercise4
{
    public class Animal
    {
        // 3 characteristics for the animal, type, weight and speed
        public string animalType{get; set;}
        public double weight{get; set;}
        public int speed{get; set;}
        // initializing everything in the constrcturo
        public Animal(String animalType, double weight, int speed)
        {
            this.animalType = animalType;
            this.weight = weight;
            this.speed = speed;
        }
        public override string ToString()
        {
            return $"Animal type {this.animalType}, Animal weight {this.weight}, Animal Speed {this.speed}";
        }
    }
}