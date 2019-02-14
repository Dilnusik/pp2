using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;                                //для того что бы юсер не ввел буквы вместо цифр
            string num = Console.ReadLine();
            bool res = false;
            while (!res)
            {
                res = int.TryParse(num, out n);
                if (res) break;
                Console.WriteLine("Error: you must write number.");
                num = Console.ReadLine();
            }
            res = false;


            string[][] a = new string[n][];        // объявление ступенчатого массива
            for (int i = 0; i < n; i++)
            {                                      // объявление размера для каждого массива(для кажд. ряда)
                a[i] = new string[i + 1];
            }
            for (int i = 0; i < a.Length; ++i)      // инициализация массива
            {
                for (int j = 0; j <= i; ++j)
                {
                    a[i][j] = "[*]";
                }
            }
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(a[i][j]); // вывод(Console.Write() без "Line" для того чтобы 1 массив был на 1 линий)
                }
                Console.WriteLine("\n");
            }
        }
    }
}