using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = " D:\\Text.txt";
            StreamReader sr = new StreamReader(path);
            int Chars = 0, Words = 0, Lines = 0;
            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                Lines++;
                Words += line.Split(' ').Length;
                Chars += line.Length;
            }
            Console.WriteLine("В тексте в файле {0} строк(и), {1} слов(а) и  {2} символов", Lines, Words, Chars);


        }
    }
}
