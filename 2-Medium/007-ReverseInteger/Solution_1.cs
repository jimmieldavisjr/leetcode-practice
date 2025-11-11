using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._2_Medium._007_ReverseInteger
{
    internal class Solution_1
    {
        public int Reverse(int x)
        {
            string s = x.ToString();
            char[] c = new char[s.Length];
            int temp = 0;
            bool neg = false;
            var sb = new StringBuilder();
            int res = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '-')
                {
                    neg = true;
                }

                c[temp] = s[i];
                temp++;
            }

            if (neg == true)
            {
                foreach (char t in c)
                {
                    if (Char.IsDigit(t))
                    {
                        sb.Append(t);
                    }
                    s = sb.ToString();
                }

                if (Int32.TryParse(s, out res))
                {
                    return -res;
                }

                else
                {
                    return 0;
                }
            }

            else
            {
                foreach (char t in c)
                {
                    if (Char.IsDigit(t))
                    {
                        sb.Append(t);
                    }
                }

                s = sb.ToString();

                if (Int32.TryParse(s, out res))
                {
                    return res;
                }

                else
                {
                    return 0;
                }
            }
        }
    }
}