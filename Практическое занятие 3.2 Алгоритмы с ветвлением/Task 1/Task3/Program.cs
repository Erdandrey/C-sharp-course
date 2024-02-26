using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст (число от 20 до 69)");
            int Age = Convert.ToInt16(Console.ReadLine());
            if (Age < 20 || Age > 69) 
            {
                Console.WriteLine("Указан неверный возраст!");
            }
            else {
                int deci = Age / 10;
                int one = Age % 10;
                string S = "";
                switch (deci)
                {
                    case 2:
                        S = S + "двадцать";
                        break;
                    case 3:
                        S = S + "тридцать";
                        break;
                    case 4:
                        S = S + "сорок";
                        break;
                    case 5:
                        S = S + "пятьдесят";
                        break;
                    case 6:
                        S = S + "шестьдесят";
                        break;
                    default: break;
                }
                switch (one)
                {
                    case 1:
                        S = S + " один год";
                        break;
                    case 2:
                        S = S + " два года";
                        break;
                    case 3:
                        S = S + " три года";
                        break;
                    case 4:
                        S = S + " четыре года";
                        break;
                    case 5:
                        S = S + " пять лет";
                        break;
                    case 6:
                        S = S + " шесть лет";
                        break;
                    case 7:
                        S = S + " семь лет";
                        break;
                    case 8:
                        S = S + " восемь лет";
                        break;
                    case 9:
                        S = S + " девять лет";
                        break;
                    default:
                        S = S + " лет"; 
                        break;
                }
                Console.WriteLine("Ваш возраст - {0}", S);
            }
        }
    }
}
