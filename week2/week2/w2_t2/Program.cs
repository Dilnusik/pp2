using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static bool IsPrime(int x)
        {
            int cnt = 0;
            for (int i = 1; i <= x; ++i)
            {
                if (x % i == 0) cnt++;
            }
            return cnt == 2;
        }
        static void Main(string[] args)
        {
            string ans = "";
            FileStream fs = new FileStream(@"C:\Users\ww\Desktop\pp2\week2\tiho.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] nums = line.Split(' ');
            int[] d = new int[nums.Length];
            for (int i = 0; i < nums.Length; ++i)
            {
                d[i] = Convert.ToInt32(nums[i]);
            }
            int cnt = 0;
            for (int i = 0; i < d.Length; ++i)
            {
                if (IsPrime(d[i]))
                {
                    if (cnt == 0)
                    {
                        ans = Convert.ToString(d[i]);
                        cnt++;
                    }
                    else
                    {
                        string t = ans + " " + Convert.ToString(d[i]);
                        ans = t;
                    }
                }
            }
            sr.Close();
            fs.Close();
            FileStream fs2 = new FileStream(@"C:\Users\ww\Desktop\pp2\week2\tiho.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            sw.Write(ans);
            sw.Close();
            fs2.Close();
        }
    }
}