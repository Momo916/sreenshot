using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    /// <summary>
    /// There has an array which length is N, the value of each element is between 0 to N-1. 
    /// Please write a method to check whether there has duplicated elements in the array 
    /// in O(n) time and O(1) extra space.
    /// </summary>
    class IfHasDupElements
    {
        public static bool IfDupM1(int[] a)
        {
            for (int i = 0; i <= a.Count() - 2; i++)
            {
                for (int j = i + 1; j <= a.Count() - 1; j++)
                {
                    if (a[i] == a[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool IfDupM2(int[] a)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int index = 0;
            foreach (var i in a)
            {
                if (dic.ContainsValue(i))
                {
                    Console.WriteLine("duplicate "+i);
                    return true;
                }
                else
                {
                    dic.Add(index++, i);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            return false;
        }
        public static bool IfDupM3(int[] a)
        {

            return false; 
        }
    }
}
