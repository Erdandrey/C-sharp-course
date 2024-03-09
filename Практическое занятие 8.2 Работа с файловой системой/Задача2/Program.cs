using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Test.txt";
            StreamWriter streamWriter = new StreamWriter(path, false);
            Random rand = new Random();
            int n = 10;
            for (int i = 0; i < n; i++) 
            {
                streamWriter.WriteLine(rand.Next(0,10));
            }
            streamWriter.Close();
            StreamReader reader = new StreamReader(path);
            int Sum = 0;
            for (int i = 0;i < n; i++)
            {
                Sum+=Convert.ToInt32(reader.ReadLine());
            }
            reader.Close();
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}
