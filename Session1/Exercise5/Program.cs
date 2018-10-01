using System;
using DNP.MathLib;
namespace Exercise5
{

    
    class Program
    {
        static void Main(string[] args)
        {
        Calculator1 calculator = new Calculator1();
        int[] array12 = new int[3];
        array12[0]=2;
        array12[1]=5;
        array12[2]=3;
        Console.WriteLine(calculator.Add(7,5));
        Console.WriteLine(calculator.Substract(6,3));
        Console.WriteLine(calculator.Multiplication(3,3));
        Console.WriteLine(calculator.Division(3,0));
        Console.WriteLine(calculator.Add(array12));
        }
    }
    
}
