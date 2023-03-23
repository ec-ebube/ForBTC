using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForBTC
{
    public class BTCLogic
    {
        //The amount of btc in your possession
        public static void acct(int value, int Available)
        {
            int btcacct = 0;
            int mainacct = 420;
            int months = 12;
            List<int> btcw = new List<int>();

            //Generating the number of btc to buy
            Random random = new Random();
            int num2buy = random.Next(1, Available);

            for (int i = 1; i <= months; i++)
            {
                
            }
        }
    }
}