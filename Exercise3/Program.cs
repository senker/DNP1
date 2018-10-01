using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var stop = 100;
            while(i <= stop)
            {
                Console.WriteLine(i);
                i=i+2;
            }
            // for(int i = 1; i<101; i++)
            // {
            //     if(i%2 == 0)
            //     {
            //      Console.WriteLine(i);
            //     }
            // }
        }
    }
}
