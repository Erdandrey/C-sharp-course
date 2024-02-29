using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[7];
            int S = 0;
            Console.WriteLine("Введите 7 целых чисел");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                S += arr[i];
            }
            float m=(float)S/arr.Length;
            Console.WriteLine("Среднее арифметическое элементов массива равно: {0}", m);
        }
    }
}
