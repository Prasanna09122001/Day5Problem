﻿using System;
using System.ComponentModel.Design;
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
        public static void Powerof2()
        {
            Console.WriteLine("Enter the value between 0-31 that to be Powered");
            int a = Convert.ToInt32(Console.ReadLine()),b=1;
            if(a>0 && a<31)
            for(int i=1;i<=a;i++)
            {
                b = b * 2;
            }
            Console.WriteLine(b);
        }
        public static void swap()
        {
            int a, b;
            Console.WriteLine("Enter the two number to be Swapped");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("Numbers after swapped ");
            Console.WriteLine(a + "," + b);
        }
        public static void OddorEven()
        {
            Console.WriteLine("Enter the Number to be checked for Odd or Even");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("It is a Even Number");
            }
            else
            {
                Console.WriteLine("It is a odd Number");
            }
        }
        public static void Largest()
        {
            Console.WriteLine("Enter the Three Number ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
                Console.WriteLine(a +" is Greatest");
            if (b > c && b > a)
                Console.WriteLine(b +" is Greatest");
            if (c > a && c > b)
                Console.WriteLine(c +" is Greatest");
        }
        public static void QuotientRemainder()
        {
            Console.WriteLine("Write the Two number that to be divided");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            float c, d;
            c = a / b;
            d = a % b;
            Console.WriteLine("Quotient = " + c + " Remainder = " + d);
        }
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter the Number to be find the Prime Factor of the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = a;
            Console.Write("The PrimeFactor of the Number is ");
            for(int i=2;i<n;i++)
            {
                if(a%i==0)
                {
                    a = a / i;
                    Console.Write(i  + " ");
                    i--;
                }
            }
        }
        public static void Vowel()
        {
            Console.WriteLine("Enter the Alphabet");
            char a = Convert.ToChar(Console.ReadLine());
            a = char.ToLower(a);
            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' )
            {
                Console.WriteLine("It is a Vowel");
            }
            else
            {
                Console.WriteLine("It is a Consonant");
            }
        }
        public static void Harmonics()
        {
            Console.WriteLine("Enter the number for the Harmonics");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i =1;i<=a;i++)
            {
                Console.WriteLine("1/"+i);
            }
        }
    }
}