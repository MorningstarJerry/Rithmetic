using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayMerge
{
    public class CompareCollections
    {
        //两个无序数组的合并算法
        public static List<int> Merge(int[] a, int[] b)
        {
            List<int> c = new List<int>();
            int i = 0;
            int j = 0;

            Array.Sort(a);
            Array.Sort(b);

            if (a == null || a.Length == 0)
            {
                return b.ToList<int>();
            }
            if (b == null || b.Length == 0)
            {
                return a.ToList<int>();
            }

            if (a[0] > b[0])
            {
                c.Add(b[0]);
                j++;
            }
            else
            {
                c.Add(a[0]);
                i++;
            }

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c.Add(a[i]);
                    i++;
                }
                else
                {
                    c.Add(b[j]);
                    j++;
                }
            }

            while (i < a.Length)
            {
                c.Add(a[i]);
                i++;
            }

            while (j < b.Length)
            {
                c.Add(b[j]);
                j++;
            }

            return c;
        }

        /// <summary>
        /// 去重复实现
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        public static List<string> distinct(string origin)
        {
            List<string> nowList = new List<string>();
            char[] array = origin.ToCharArray();
            nowList.Add(array[0].ToString());

            for (int i = 0; i < array.Length; i++)
            {
                int j = 0;
                while (j < nowList.Count)
                {
                    if (array[i].ToString() == nowList[j])
                    {
                        break;
                    }
                    else
                    {
                        j++;
                    }

                    if (j == nowList.Count)
                    {
                        nowList.Add(array[i].ToString());
                    }
                }
            }
            return nowList;
        }


        /// <summary>
        /// 分割算法
        /// </summary>
        /// <param name="input"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static string[] SplitBy(string input, string sp)
        {
            if (string.IsNullOrWhiteSpace(input) || sp == null)
            {
                return null;
            }
            List<string> output = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                int j = input.IndexOf(sp, i);
                string temp = "";
                if (j >= 0)
                {
                    temp = input.Substring(i, j - i);
                    output.Add(temp);
                    i = j + sp.Length - 1;
                }
                else
                {
                    temp = input.Substring(i);
                    if (!string.IsNullOrEmpty(temp))
                    {
                        output.Add(temp);
                    }
                    break;
                }
            }
            return output.ToArray<string>();
        }

        /// <summary>
        /// int parse 实现
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long TransToNumber(string str)
        {
            if (str == null || str.Length == 0)
            {
                return -1;
            }

            int result = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (0 <= (str[j] - '0') && (str[j] - '0') <= 9)
                {
                    checked
                    {
                        result = result * 10 + (str[j] - '0');
                    }
                }
                else
                {
                    return -1;
                }
            }
            return result;
        }
    }
}
