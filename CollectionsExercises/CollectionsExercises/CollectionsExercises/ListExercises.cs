
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var myList = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    myList.Add(i);
                }
            }
            return myList;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            double i = 0;
            argList.ForEach(delegate (double num) { i += num; });
            i /= argList.Count;
            i = argList.Count == 0 ? 0 : i;

            return i;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var sList = new List<string>();
            sourceList.ForEach(delegate (string source) { if (source.StartsWith('a') || source.StartsWith('A')) { sList.Add(source); } });
            return sList;
        }
    }
}
  