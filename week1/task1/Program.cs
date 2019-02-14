using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Program1
    {
        public bool PrimeNum(int a)                     //метод для того что бы узнать простое или нет число
        {
            int x = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0) x++;
            }
            if (x == 2) return true;                    // возвращает true or false
            else return false;
        }
        static void Main(string[] args)
        {
            List<int> b = new List<int>();                 //новый пустой лист(контейнер) для простых чисел 
            //int n = int.Parse(Console.ReadLine());
            int n = 1;                                      //для того что бы юсер не ввел буквы вместо чисел
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
            int[] a = new int[n];                          //объявление массива
            int y = 0;                                     //счетчик для списка простых чисел, а то в "list"-е нет функций
            for (int i = 0; i < n; i++)                                                                         //Length
            {
                //a[i] = int.Parse(Console.ReadLine());
                num = Console.ReadLine();                   //для того что бы юсер не ввел буквы вместо чисел
                int jj;
                while (!res)
                {
                    res = int.TryParse(num, out jj);
                    if (res)
                    {
                        res = false;
                        break;
                    }
                    Console.WriteLine("Error: you must write number.");
                    num = Console.ReadLine();
                }
                jj = int.Parse(num);
                a[i] = jj;
                Program1 p = new Program1();
                if (p.PrimeNum(a[i]))                      //используем метод
                {
                    b.Add(a[i]);                           //добавление в новый список если a[i] простое число
                    y++;
                }
            }
            Console.WriteLine(y);                          //размер списка
            for (int i = 0; i < y; i++)                    // вывод простых чисел
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("\n");
        }

    }

}
