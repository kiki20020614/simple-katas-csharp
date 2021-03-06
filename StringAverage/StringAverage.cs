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
            {"nine", 9},
            {"zero", 0},
        };

        public static string StringAvg(string collectionStr)
        {
            collectionStr = collectionStr.ToLower();

            var sRtn = string.Empty;
            var intResult = 0;
            var splitStr = collectionStr.Split(' ');

            if (splitStr.Any(s => string.IsNullOrEmpty(s) || !strMappingNum.ContainsKey(s)))
            {
                sRtn = "n/a";
            }
            else
            {
                intResult = (strMappingNum.Sum(r => splitStr.Contains(r.Key) ? r.Value : 0)) / splitStr.Length;
                sRtn = strMappingNum.FirstOrDefault(x => x.Value == intResult).Key;
            }

            return sRtn;
        }
    }
}