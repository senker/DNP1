using System;

namespace testClass2
{
    class Person
    {
        public String name;
        public Person(String name)
        {
            this.name=name;
        }
        public void Introduce()
        {
            System.Console.WriteLine("Hi my name is "+name);
        }
            
        
    }
}