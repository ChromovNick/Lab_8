using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo("D:/Test");
            DirectoryInfo[] darray = directory.GetDirectories();
            Console.WriteLine("Вложенные файлы:{0}", directory.GetFiles());
            foreach (DirectoryInfo d in darray)
            { 
                Console.WriteLine("Вложенные директории:{0}", d.Name);
                d.GetFiles();
                FileInfo[] files = d.GetFiles();
                if (null != files)
                {
                    foreach (FileInfo file in files)
                    {
                        Console.WriteLine("файлы вложенных директорий:{0}", file.Name);
                    }
                }
                else
                {
                    Console.WriteLine("");
                }
            }

            Console.ReadKey();
        }
    }
}


         