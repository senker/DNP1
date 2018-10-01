using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down the first number!");
            int intTemp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your first number is "+intTemp1);
            Console.WriteLine("Write down the second number!");
            int intTemp2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your second number is "+intTemp2);
            
            if (intTemp1 > intTemp2)
            {
                Console.WriteLine("First number is the winner!");
            }
            else
                {
                Console.WriteLine("Second number is the winner!");
                }
        }
    }
}
