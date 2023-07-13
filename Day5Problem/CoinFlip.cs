using System;
using System.Globalization;

namespace Day5Problem
{
    public class CoinFlip
    {
        public  static void play()
        {
            Random random = new Random();
            Console.WriteLine("Enter the Number of the times the coin needed to be Flipped");
            int num = Convert.ToInt32(Console.ReadLine());
            int Head = 0, Tail = 0;
            for(int i=0;i<num;i++)
            {
                double check = random.NextDouble();
                if (check < 0.5)
                    Tail++;
                else
                    Head++;
            }
            Console.WriteLine("Percentage of Head " + (Head*100)/num);
            Console.WriteLine("Percentage of Tail " + (Tail*100)/num);
        }
        public static void Leap()
        {
            Console.WriteLine("Enter the Year ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>=1000 && a<=9999)
            {
                if(a%4==0)
                {
                    Console.WriteLine("It is a Leap Year");
                }
                else
                {
                    Console.WriteLine("It is a Non-Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Write The Correct four digit Year");
            }
        }
    }
}