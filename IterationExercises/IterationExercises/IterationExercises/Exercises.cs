using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int i = int.MaxValue;
            foreach (var num  in nums)
            {
                if (num < i)
                {
                    i = num;
                }
            }
            return i;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int x = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    x += i;
                }
            }
            return x;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            string aa;
            int b = 0;
            input.ToLower();
            foreach (var i in input)
            {
                switch (i)
                {
                    case 'a':
                        int a += 1;
                        break;

                    case 'b':
                        b += 1;
                        break;

                    case 'c':
                        b += 1;
                        break;

                    case 'd':
                        b += 1;
                        break
                            ;
                        //default:
                        
                }
            }
            return b.ToString();
        }
    }
}