using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            int i = 0;
            int max = 0;
            while (i < nums.Length)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                i ++;
            }
            return max;
        }

        public static int HighestForLoop(int[] nums)
        {
            int max = 0;
            // this method should use a for loop
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int max = 0;
            // this method should use a for-each loop
            foreach (var i in nums)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int max = 0;
            int i = 0;

            do
            {
                if (i > max)
                {
                    max = i;
                }
                i++;

            } while (i < nums.Length);

            return max;
        }
    }
}