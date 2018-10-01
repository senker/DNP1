using System;

namespace Exercise8
{
    class StringUtility
    {
        
        public void SummarizeText(String testString)
        {
            // int length1 = testString.Length;
            Char[] charArray = testString.ToCharArray();
            // Console.WriteLine(result);
            // for(int i=0; i<charArray.Length; i++)
            // {
            //     counter = counter+charArray[i].Length;
            //     // Console.WriteLine(charArray[i].Length);
            // }
            if(charArray.Length>20)
            {

                for(int i=0; i<=20; i++)
                {
                    Console.Write(charArray[i]);
                }
                Console.WriteLine("...");
            }
            else
            {
                Console.WriteLine(testString);
            }
        }
    }
}