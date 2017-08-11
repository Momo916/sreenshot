using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    public class TwoSum
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //Example:
        //Given nums = [2, 7, 11, 15], target = 9,
        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].

        public static int[] twoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }
        public static int[] twoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int com = target - nums[i];
                if (dic.ContainsKey(com) && dic[com] != i)
                {
                    return new int[] { i, dic[com] };
                }
            }
            throw new ArgumentException("No two sum solution");
        }
        public static int[] twoSum3(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int com = target - nums[i];
                if (dic.ContainsKey(com))
                {
                    return new int[] { dic[com], i };
                }
                dic.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
