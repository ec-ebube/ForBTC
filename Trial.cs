using System;
namespace ForBTC
{
    public class Trial
    {
        //For trying before using
        public static void Trying(int value, int Available)
        {
            Random random1 = new Random();

            List<int> dddd = new List<int>();

            Console.WriteLine("Put a starting number you want to buy");
            int input = /*Convert.ToInt32(Console.ReadLine())*/23;
            int bought = 1;

            for (int i = 1; i < 3; i++)
            {
                int tobuy = random1.Next(1, Available);
                if (i == 1 && input < Available)
                {
                    bought = input * value;
                    dddd.Add(bought);
                }
                else if (i != 1)
                {
                    bought = tobuy * value;
                    dddd.Add(bought);
                }
            }
        }
    }
}