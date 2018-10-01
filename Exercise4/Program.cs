using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            
             switch (number) 
            {
            case 0: Console.WriteLine("This is first number");
            break;
            case 10: Console.WriteLine("this is last number");
            break;
            default: 
            {
                if (number>0&&number<10)
                {
                    Console.WriteLine(number);
                }
                else 
                {
                    Console.WriteLine("invalid number");
                }
                break;
            }
            
            }
            
    }
}
}