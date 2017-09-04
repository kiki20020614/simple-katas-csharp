﻿using System.Collections.Generic;
using System.Linq;

namespace StringAverage
{
    public class StrAvg
    {
        private static Dictionary<string, int> strMappingNum = new Dictionary<string, int>{
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"night", 9},
            {"zero", 0},
        };

        public static string StringAvg(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "n/a";

            var num = strMappingNum.Select(m => m).Where(a => a.Key == str).FirstOrDefault();
            if (num.Key == null)
            {
                return "n/a";
            }

            return str;
        }
    }
}