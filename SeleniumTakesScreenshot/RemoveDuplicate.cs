using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    public class RemoveDuplicate
    {
        //Given a sorted array, remove the duplicates in place so that each element appears only once and return the new length.
        //Do not allocate extra space for another array, you must do this in place with constant memory. 

        //For example,
        //Given input array intArray = [1,1,2], 
        //Your function should return length = 2, with the first two elements of intArray being 1 and 2 respectively. It doesn't matter what you leave beyond the new length. 

        public static int removeDup(int[] intArray)
        {
            int count = 0;
            int n = intArray.Length;
            for (int i = 1; i < n; i++)
            {
                if (intArray[i] == intArray[i - 1])
                {
                    count++;
                }
                else
                {
                    intArray[i - count] = intArray[i];
                }
            }
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            return n - count;
        }


    }
}
