using System;

namespace Day5Problem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Solution for the Day Five Problem");
            Console.WriteLine("Write the Program to be Executed");
            Console.WriteLine("1.CoinFlip\n2.Leap Year\n3.Power Multiple of 2\n4.Swapping\n5.Odd or Even\n6.Largest among 3 Numbers\n7.Quotient and Remainder\n8.Prime Factor\n9. Vowel Or Consonant\n10.Harmonics ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: CoinFlip.play(); break;
                case 2: CoinFlip.Leap(); break;
                case 3: CoinFlip.Powerof2(); break;
                case 4: CoinFlip.swap(); break;
                case 5: CoinFlip.OddorEven(); break;
                case 6: CoinFlip.Largest(); break;
                case 7: CoinFlip.QuotientRemainder(); break;
                case 8: CoinFlip.PrimeNumber(); break;
                case 9: CoinFlip.Vowel(); break;
                case 10: CoinFlip.Harmonics(); break;
            }
        }
    }
}