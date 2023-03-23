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
            string s1 = "Hello C Sharp";
            string[] s2 = s1.Split("");
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }
        }
    }
}