using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._451_sol1;

public class Solution_1
{
    public string FrequencySort(string s) // tree
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], 1);
            }

            else
            {
                dict[s[i]] += 1;
            }
        }

        List<KeyValuePair<char, int>> pairs = new List<KeyValuePair<char, int>>(dict);

        pairs.Sort(delegate (KeyValuePair<char, int> x, KeyValuePair<char, int> y)
        {
            return y.Value.CompareTo(x.Value);
        });

        foreach (var pair in pairs)
        {
            for (int i = 0; i < pair.Value; i++)
            {
                sb.Append(pair.Key);
            }
        }
        return sb.ToString();
    }
}

