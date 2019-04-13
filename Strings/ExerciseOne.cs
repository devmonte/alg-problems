using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    //Find most popular character in given string
    public class ExerciseOne
    {
        public char FindMostFrequentCharacterInString(string input)
        {
            var inputArray = input.ToArray();
            var charDict = new Dictionary<char, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (charDict.Any(k => k.Key == inputArray[i]))
                    charDict[inputArray[i]]++;
                else
                    charDict.Add(inputArray[i], 1);
            }

            int max = 0;
            char found = '0';
            foreach (var item in charDict.Keys)
            {
                if (max < charDict[item])
                {
                    max = charDict[item];
                    found = item;
                }
            }
            return found;
        }

        public char FindMostFrequentCharacterInStringWithLINQ(string input)
        {
            var t = input.GroupBy(s => s).OrderByDescending(x => x.Count()).First().Key;
            return t;
        }
    }
}
