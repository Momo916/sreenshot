using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    //Given a string, find the length of the longest substring without repeating characters. -- George下次讲解（二选一）
    //Examples:
    //  Given "abcabcbb", the answer is "abc", which the length is 3.
    //  Given "bbbbb", the answer is "b", with the length of 1.
    //  Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
    public class longestSubString
    {
        public static int lengthOfLongestSubstring(String s)
        {
            if (s == null)
            {
                Console.WriteLine("The input is null!");
                return 0;
            }
            if (s.Length <= 1)
            {
                return s.Length;
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int max = 0;
            for (int i = 0, j = 0; i < s.Length; ++i)
            {
                if (dic.ContainsKey(s[i]))
                {
                    j = dic[s[i]] + 1;
                    dic[s[i]] = i;
                }
                else
                {
                    dic.Add(s[i], i);
                    
                }
                max = Math.Max(max, i - j + 1);
            }
            return max;
        }

        public static int Queue(string s)
        {
            if (s == null)
            {
                Console.WriteLine("The input is null!");
                return 0;
            }
            if (s.Length <= 1)
            {
                return s.Length;
            }
            int max = 0;
            Queue<char> queue = new Queue<char>();
            foreach (var item in s)
            {
                if (queue.Contains(item))
                {
                    while (queue.Peek() != item)
                    {
                        queue.Dequeue();
                    }
                    queue.Dequeue();
                }
                queue.Enqueue(item);
                max = Math.Max(max, queue.Count);
            }
            return max;
        }

        //public int lengthOfLongring(String s)
        //{
        //    if (s.Length == 0) return 0;
        //    HashMap<char, int> map = new HashMap<char, int>();
        //    int max = 0;
        //    for (int i = 0, j = 0; i < s.Length; ++i)
        //    {
        //        if (map.containsKey(s.charAt(i)))
        //        {
        //            j = Math.Max(j, map.get(s.charAt(i)) + 1);
        //        }
        //        map.put(s.charAt(i), i);
        //        max = Math.Max(max, i - j + 1);
        //    }
        //    return max;
        //} 
    }
}
