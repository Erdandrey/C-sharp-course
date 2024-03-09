using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random R = new Random();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(-50, 50);
                Console.Write("{0} ", arr[i]);
                if (( i % 2 == 0) && (arr[i] > 0) && (arr[i] % 2 == 1)) //вопрос как считать места в массиве, по индексам от 0 до 19 или "по-человечески" от 1 до 20
                {
                    counter++;
                }
            }
            Console.WriteLine();         
            Console.WriteLine("Rоличество нечетных положительных элементов, стоящих на четных местах: {0}", counter);
            Console.ReadKey();
        }
    }
}
