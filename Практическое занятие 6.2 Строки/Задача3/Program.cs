using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string Str = Console.ReadLine();
            char[] arr = Str.ToCharArray();
            string FinalString = "";
            int counter = 0;
            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=='{')
                {
                    flag = false;
                    counter++;
                }
                if (flag) 
                {
                    FinalString += arr[i];
                }
                else if (arr[i] == '}')
                {
                    counter--;
                }
                if (counter == 0) 
                {
                    flag = true;
                }
            }
            Console.WriteLine(FinalString);
            Console.ReadKey();
        }
    }
}
