using System;

namespace DNP.MathLib
    {
    class Calculator1
    {
        
        // public Calculator(int number1, int number2)
        // {
        //     this.number1=number1;
        //     this.number2=number2;
        // }
        public int Add(int number1, int number2)
        {
            return number1+number2;
        }
        public int Substract(int number1, int number2)
        {
            return number1-number2;
        }
        public int Multiplication(int number1, int number2)
        {
            if (number1 == 0 || number2 == 0)
            {
                return 0;
            }
            return number1*number2;
        }
        public int Division(int number1, int number2)
        {
            if (number1 == 0 || number2 == 0)
            {
            Console.WriteLine("Impossible division");    
            }
            return number1/number2;
        }
        public int Add(int[] array1)
        {
            int total = 0;
            for(int i = 0; i<array1.Length; i++)
            {
                total += array1[i];
            }
            return total;
        }
    }
    
    
}