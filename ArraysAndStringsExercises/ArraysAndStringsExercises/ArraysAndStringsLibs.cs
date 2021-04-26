
using System;
using System.Text;

namespace ArraysAndStringsLib
{
    public class Exercises
    {
        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            string address = ($"{number} {street}, {city} {postcode}.");
            
            return address;
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            var result = Math.Round(((score / outOf) * 100.0),1);
            return result.ToString();      
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            double num = 0;
            bool a = double.TryParse(numString, out num);
            if (a)
            {
                return double.Parse(numString);
            }
            else
            {
                return -999;
            }
            
        }
        public static string ManipulateString(string input, int num)
        {

            throw new NotImplementedException();
        }
    }
}