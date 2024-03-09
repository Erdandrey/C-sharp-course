using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Temp";
            string[] dir = Directory.GetFiles(path,"*.*", SearchOption.AllDirectories);
            foreach (string dir2 in dir)
            {
                Console.WriteLine(dir2);
            }
            Console.ReadKey();
        }
    }
}
