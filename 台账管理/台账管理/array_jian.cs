using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 台账管理
{
    class array_jian
    {
        public string[] str(int a,string[] str1)
        {
            List<string> list1 = new List<string>();
            // String数组转List集合
            for (int i = 0; i < str1.Length; i++)
            {
                list1.Add(str1[i]);
            }
            list1.RemoveAt(a);
            string[] str2 = new string[list1.Count];
            for (int i = 0; i < list1.Count; i++)
            {
                str2[i] = list1[i];
            }
            return str2 ;
        }
        public string[] jian(string a, string[] str1)
        {
            List<string> list1 = new List<string>();
            // String数组转List集合
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != a)
                {
                    list1.Add(str1[i]);
                }
            }
            string[] str2 = new string[list1.Count];
            for (int i = 0; i < list1.Count; i++)
            {
                str2[i] = list1[i];
            }
            return str2;
        }
        public string[] add(string [] str1,string[] a)
        {
            List<string> list1 = new List<string>();
            // String数组转List集合
            if (str1!=null)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    list1.Add(str1[i]);
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                list1.Add(a[i]);
            }
            string[] str2 = new string[list1.Count];
            for (int i = 0; i < list1.Count; i++)
            {
                str2[i] = list1[i];
            }
            return str2;
        }
        public string[] add_one(string[] str1, string a)
        {
            List<string> list1 = new List<string>();
            // String数组转List集合
            if (str1 != null)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    list1.Add(str1[i]);
                }
            }
            list1.Add(a);
            
            string[] str2 = new string[list1.Count];
            for (int i = 0; i < list1.Count; i++)
            {
                str2[i] = list1[i];
            }
            return str2;
        }
        public int[] str(int a, int[] str1)
        {
            List<int> list1 = new List<int>();
            // String数组转List集合
            for (int i = 0; i < str1.Length; i++)
            {
                list1.Add(str1[i]);
            }
            list1.RemoveAt(a);
            int[] str2 = new int[list1.Count];
            for (int i = 0; i < list1.Count; i++)
            {
                str2[i] = list1[i];
            }
            return str2;
        }
        public string[] quchong(string[] str)
        {
            List<string> list1 = new List<string>();
            // String数组转List集合
            for (int i = 0; i < str.Length; i++)
            {
                list1.Add(str[i]);
            }
            for(int i = 0; i < list1.Count; i++)
            {
                for(int j = i+1; j < list1.Count; j++)
                {
                    for (int k = j; k < list1.Count; k++)
                    {
                        if (list1[i] == list1[j])
                        {
                            list1.RemoveAt(j);
                        }
                    }
                }
            }
            string[] str2 = new string[list1.Count];
            for (int i = 0; i < list1.Count; i++)
            {
                str2[i] = list1[i];
            }
            return str2;
        }
    }
}
