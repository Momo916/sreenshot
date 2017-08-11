using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    public static class Reverse
    {
        public static string reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

    }
}
