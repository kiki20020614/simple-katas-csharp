using System.Collections.Generic;
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

        public static string StringAvg(string collectionStr)
        {
            collectionStr = collectionStr.ToLower();

            var sRtn = "n/a";
            var intResult = 0;
            var splitStr = collectionStr.Split(' ');
            foreach (var singleStr in splitStr)
            {
                if (string.IsNullOrEmpty(collectionStr) || !strMappingNum.ContainsKey(singleStr))
                {
                    return sRtn;
                }

                var num = strMappingNum.FirstOrDefault(x => x.Key == singleStr).Value;
                intResult += num;
            }
            intResult = intResult/splitStr.Length;
            sRtn = strMappingNum.FirstOrDefault(x => x.Value == intResult).Key;

            return sRtn;
        }
    }
}