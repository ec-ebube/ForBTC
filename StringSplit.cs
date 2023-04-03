using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForBTC
{
    public class StringSplit
    {
        //Write a funtion that splits strings
        public static void splistring()
        {
            string myString = "Hello, World!";
            char[] delimiterChars = { ' ' };
            string[] words = myString.Split(delimiterChars);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}