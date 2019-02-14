using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    class Student                                 // создаем класс
    {
        string name;                              // переменные класса
        string id;
        public int yearofStudy;

        public Student(string n, string i)        // конструктор с 2 параметрами
        {
            name = n;
            id = i;
        }

        public void data()                         // метод который выводит данные студента
        {
            Console.WriteLine("Name of student: " + name + "\n" + "ID of student: " + id);
        }

        public int NextYear(int y)               // метод который изменяет курс обучение студента на +1
        {
            yearofStudy = y;
            return yearofStudy + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");
            string sName = Console.ReadLine();       // ввод данных студента
            Console.WriteLine("Write ID: ");
            string sId = Console.ReadLine();


            Console.WriteLine("Write year of study: ");
            int sYear;
            string num = Console.ReadLine();            // для того что бы юсер не ввел буквы вместо цифр
            bool res = false;
            while (!res)
            {
                res = int.TryParse(num, out sYear);
                if (res) break;
                Console.WriteLine("Error: you must write number.");
                num = Console.ReadLine();
            }
            sYear = int.Parse(num);


            Student s = new Student(sName, sId);      // конструктор
            s.data();
            Console.WriteLine("Next Year of study: " + s.NextYear(sYear));
        }
    }
}
