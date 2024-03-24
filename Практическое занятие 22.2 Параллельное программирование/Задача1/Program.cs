using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(CreateArr);
            Task<int[]> task1 = new Task<int[]>(func1, n);


            Func < Task<int[]>, int> func2 = new Func<Task<int[]>, int> (GetSumm);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetMax);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            task1.Start();
            foreach (var item in task1.Result) { Console.Write("{0} ", item); } //для вывода тоже можно было создать свой метод, но я решил попробовать сделать так.
            Console.WriteLine();
            Console.WriteLine(task2.Result);
            Console.WriteLine(task3.Result);
            Console.ReadKey();
        }

        static int[] CreateArr(object a)
        {
            int n = (int)a;
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0,100);
            }
            return arr;
        }
        static int GetSumm(Task<int[]> task)
        {
            int[] arr = task.Result;
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
            }
            return summ;
        }
        static int GetMax(Task<int[]> task)
        {
            int[] arr = task.Result;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
