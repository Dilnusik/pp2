using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\ww\Desktop\pp2\week2\file.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            if (IsPal(sw.ReadLine()))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static bool IsPal(string x)
        {
            for (int i = 0; i < x.Length / 2; ++i)
            {
                if (x[i] != x[x.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}