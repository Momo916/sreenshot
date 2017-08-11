using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    //Given a sorted integer array without duplicates, return the summary of its ranges.

    //For example, given [0,1,2,4,5,7], return ["0->2","4->5","7"]. 

    public class SummaryofRange
    {
        public static List<string> summaryRanges(int[] nums)
        {
            List<string> list = new List<string>();
            if (nums.Length == 1)
            {
                list.Add(nums[0] + "");
                return list;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                while (i + 1 < nums.Length && (nums[i + 1] - nums[i]) == 1)
                {
                    i++;
                }
                if (a != nums[i])
                {
                    list.Add(a + "->" + nums[i]);
                }
                else
                {
                    list.Add(a + "");
                    //list.Add(a.ToString());
                }
            }
            return list;
        }

    }
}
