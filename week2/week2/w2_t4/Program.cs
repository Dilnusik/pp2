using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"C:\Users\ww\Desktop\pp2\week2\path\newf.txt", FileMode.Create)) { } //создал файл, если сущ то перезаписывается

            string fileName = "newf.txt";  //сам файл который долж скопироаваться
            string path = @"C:\Users\ww\Desktop\pp2\week2\path\";      //источник
            string path1 = @"C:\Users\ww\Desktop\pp2\week2\path1\";    //цель

            string Ffile = Path.Combine(path, fileName);  // сведения о пути
            string Sfile = Path.Combine(path1, fileName);


            File.Copy(Ffile, Sfile, true);   //копирование
            File.Delete(@"C:\Users\ww\Desktop\pp2\week2\path\newf.txt"); // удаление оригинала

        }
    }
}