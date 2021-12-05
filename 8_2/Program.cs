using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:/Test/Numbers.txt");
            Random random = new Random();
            int[] array = new int[10];
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0,10);
                sw.WriteLine(array[i]);
            }
            sw.Close();
            StreamReader sr = new StreamReader("D:/Test/Numbers.txt");
            string[] readarray = File.ReadAllLines("D:/Test/Numbers.txt");
            int[] intarray = new int [readarray.Length];
            int Sum = 0;
            for (int i = 0; i < readarray.Length; i++)
            {
                intarray[i] = int.Parse(readarray[i]);
            }
            S=intarray.Sum();
            Console.WriteLine("{0}", S);
            Console.ReadKey();
        }
    }
}
