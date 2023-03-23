using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForBTC
{
    public class Price
    {
        //Create a function that automatically buys or sells crypto based on last sell and calculates 
        //the profit or lose after a certain period of time
        public static void BtcAmount(int value, int Available)
        {
            

            Console.WriteLine($"The BTC value for this month is ${value} and {Available} coins are avaliable");
            Console.WriteLine();
        }

    }
}