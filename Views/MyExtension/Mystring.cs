using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrapdemo.Views.MyExtension
{
    public static class Mystring
    {
        public static int WordCount(this string str)
        {
            return str.Split(' ').Count();



        }

        public static void Test()
        {
            string s = "a b a c s s d d";
            s.WordCount();
        }

    }
}