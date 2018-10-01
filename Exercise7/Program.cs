using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down your name!");
            String name = Console.ReadLine();
            // Harder way to reverse a name *using a Reverse built-in method*
            // char[] reverseName = name.ToCharArray();
            // Array.Reverse(reverseName);
            // Console.WriteLine(reverseName);

            for (int i = name.Length-1;  i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            
        }
    }
}
