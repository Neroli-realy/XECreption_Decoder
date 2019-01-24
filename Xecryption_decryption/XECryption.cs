using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xecryption_decryption
{
   internal class XECryption
    {
        public static string Decryption(string encrypted,string pw,bool Ykey)
        {
            string result="";

            List<string> nums = new List<string>(encrypted.Split('.'));
            List<int> sums = new List<int>();
            List<int> res = new List<int>();
            int charac = 0;
            int min;
            for (int i = 2; i < nums.Count; i++)
            {
                charac = 0;
                i--;
                for (int count = 1; count <= 3; count++)
                {
                    charac += int.Parse(nums[i]);

                    if (i < nums.Count) i++;
                }
                sums.Add(charac);

            }
            min = sums.Min();

            for (int i = 0; i < sums.Count; i++)
            {
                if (Ykey)
                {
                    int key = 0;
                    foreach (char c in pw)
                    {
                        key += (int)c;
                    }
                    res.Add(sums[i] - key);
                }
                else
                {
                    res.Add((sums[i] - min) + 10);
                }
            }

            for (int i = 0; i < res.Count; i++)
            {
                result += (char)res[i];
            }

            return result;
        }

    }
}
