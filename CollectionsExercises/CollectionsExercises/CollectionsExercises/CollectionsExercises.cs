
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            Stack stack = new Stack<string>();
            for (int i = 0; i <= queue.Count; i++)
            {
                return queue.Dequeue();
            }

            return queue.Dequeue();
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        { 
            var stack = new Stack<int>();
            foreach (var item in original)
            {
                stack.Push(item);
            }

            var arrayStack = stack.ToArray();
            return arrayStack;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var counts = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (input.Contains(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts.Add(c, 1);
                }
            }

            return " ";
        }
    }
}