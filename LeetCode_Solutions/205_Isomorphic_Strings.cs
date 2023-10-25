using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _205_Isomorphic_Strings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> dicS = new Dictionary<char, char>();


            for (int i = 0; i < s.Length; i++)
            {
                if (dicS.ContainsKey(s[i]) == false)
                {
                    dicS.Add(s[i], t[i]);
                }
            }
            
            Dictionary<char, char> dicT = new Dictionary<char, char>();

            for (int i = 0; i < t.Length; i++)
            {
                if (dicS.ContainsKey(t[i]) == false)
                {
                    dicS.Add(t[i], t[i]);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];  

                if(dicS.ContainsKey(charS) && dicT.ContainsKey(charT))
                {
                    dicS.TryGetValue(s[i], out char sValue);
                    if(sValue == charS)
                    { return false; }
                    dicT.TryGetValue(s[i], out char tValue);
                    if(tValue == charT)
                    { return false; }
                }
                else { return false; }
            }

            //for (int i = 0; i < s.Length; )
            //{
            //    if(dicS.ContainsKey(s[i]))
            //    {
            //        dicS.TryGetValue(s[i], out char sValue);

            //        if(sValue == t[i])
            //        {
            //            i++;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else { return false; }
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    //dicS.TryGetValue(s[i], out char sValue);

            //    if (!dicS.ContainsKey(s[i]) && dicS.TryGetValue(s[i], out char sValue) && sValue != t[i])
            //    {
            //        return false;
            //    }
            //}

           
            return true;
        }

        public static bool IsIsometricSecond(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> dic = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] != t[i])
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (dic.ContainsValue(t[i]))
                {
                    return false;
                }
                dic[s[i]] = t[i];
            }
            return true;
        }
    }
}
