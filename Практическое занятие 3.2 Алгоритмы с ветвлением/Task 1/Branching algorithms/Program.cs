using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X первой точки");
            int X1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки");
            int Y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату X второй точки");
            int X2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки");
            int Y2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату X третьей точки");
            int X3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y третьей точки");
            int Y3 = Convert.ToInt16(Console.ReadLine());
            //int X1 = 1, Y1 = 4, X2 =4, Y2 = 1, X3 = 4, Y3 = 2;
            int X4=0, Y4=0;
            bool flag = true;
            if (X1 == X2 ||  X1 == X3)
            {
                if (Y1 == Y2 || Y1 == Y3)
                {
                    if (X1 == X3)
                    {
                        X4 = X2;
                    }
                    else if (X1 == X2)
                    {
                        X4 = X3;
                    }
                    else
                    {
                        flag = false;
                    }
                    if (Y1 == Y2)
                    {
                        Y4 = Y3;
                    }
                    else if (Y1 == Y3)
                    {
                        Y4 = Y2;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else if (Y2 == Y3)
                {
                    Y4 = Y1;
                    if (X1 == X2)
                    {
                        X4 = X3;
                    }
                    else if (X1 == X3)
                    {
                        X4 = X2;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            else if (X2==X3)
            {
                X4 = X1;
                if (Y1 == Y2)
                {
                    Y4 = Y3; 
                }
                else if (Y1 == Y3)
                {
                    Y4 = Y2;
                }
                else
                {
                    flag = false;
                }
            }
            else
                {
                    flag = false;
                }


            if (flag)
            {
                Console.WriteLine("Координата X искомой точки {0}. Координата Y искомой точки {1}. ",X4,Y4);
            }
            else
            {
                Console.WriteLine("Точки не соответствуют условию");
            }
            Console.ReadKey();
        }
    }
}
