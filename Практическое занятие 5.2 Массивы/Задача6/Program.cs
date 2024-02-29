using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите целое положительное число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[N, N];
            Console.WriteLine("Теперь заполним указанный массив NxN целыми числами");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введённый массив:");
            bool flag = true;
            int ControlSum1 = 0, ControlSum2 = 0, SumCol = 0, SumRow=0;

            for (int i = 0; i < N; i++) //добавил вывод массива чтоб удобней было проверять + подсчёт проверочной суммы
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        ControlSum1 += arr[i,j];
                    }
                    if (i+j == N-1)
                    {
                        ControlSum2 += arr[i,j];
                    }
                    Console.Write("{0} ", arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма по диагоналям, столбцам и строкам должна быть равна: {0}", ControlSum1);// для проверки, чтобы проще считать
            if (ControlSum1 != ControlSum2)
            {
                flag = false;
            }
            else
            {
                for (int i = 0; i < N; i++)
                {

                    for (int j = 0; j < N; j++)
                    {
                        SumCol += arr[i,j];
                        SumRow += arr[j,i];
                    }
                    if ((SumCol != ControlSum1)||(SumRow != ControlSum1))
                    {
                        flag = false;
                        break;
                    }
                    SumCol = 0;
                    SumRow = 0;
                }
            }
            if (flag)
            {
                Console.WriteLine("Этот квадрат магический!");
            }
            else
            {
                Console.WriteLine("Этот квадрат не магический!");
            }

        }
    }
}
