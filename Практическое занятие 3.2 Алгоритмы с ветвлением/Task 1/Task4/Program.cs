using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999");
            int Num = Convert.ToInt16(Console.ReadLine());
            if (Num < 100 || Num > 999)
            {
                Console.WriteLine("Неверно указано число!");
            }
            else
            {
                int century = Num / 100;
                int check = Num % 100;
                int deci = check / 10;
                int one = Num % 10;
                string S = "";
                switch (century)
                {
                    case 1:
                        S = S + "сто";
                    break;
                    case 2:
                        S = S + "двести";
                        break;
                    case 3:
                        S = S + "триста";
                        break;
                    case 4:
                        S = S + "четыреста";
                        break;
                    case 5:
                        S = S + "пятьсот";
                        break;
                    case 6:
                        S = S + "шестьсот";
                        break;
                    case 7:
                        S = S + "семьсот";
                        break;
                    case 8:
                        S = S + "восемьсот";
                        break;
                    case 9:
                        S = S + "девятьсот";
                        break;
                    default: break;
                }
                if (check < 20 && check > 9)
                {
                    switch (check)
                    {
                        case 10:
                            S = S + " десять";
                            break;
                        case 11:
                            S = S + " одиннадцать";
                            break;
                        case 12:
                            S = S + " тринадцать";
                            break;
                        case 14:
                            S = S + " четырнадцать";
                            break;
                        case 15:
                            S = S + " пятнадцать";
                            break;
                        case 16:
                            S = S + " шестнадцать";
                            break;
                        case 17:
                            S = S + " семнадцать";
                            break;
                        case 18:
                            S = S + " восемнадцать";
                            break;
                        case 19:
                            S = S + " девятнадцать";
                            break;
                        default: break;
                    }
                }
                else
                {
                    switch (deci)
                    {
                        case 2:
                            S = S + " двадцать";
                            break;
                        case 3:
                            S = S + " тридцать";
                            break;
                        case 4:
                            S = S + " сорок";
                            break;
                        case 5:
                            S = S + " пятьдесят";
                            break;
                        case 6:
                            S = S + " шестьдесят";
                            break;
                        case 7:
                            S = S + " семьдесят";
                            break;
                        case 8:
                            S = S + " восемьдесят";
                            break;
                        case 9:
                            S = S + " девяносто";
                            break;
                        default: break;
                    }
                    switch (one)
                    {
                        case 1:
                            S = S + " один";
                            break;
                        case 2:
                            S = S + " два";
                            break;
                        case 3:
                            S = S + " три";
                            break;
                        case 4:
                            S = S + " четыре";
                            break;
                        case 5:
                            S = S + " пять";
                            break;
                        case 6:
                            S = S + " шесть";
                            break;
                        case 7:
                            S = S + " семь";
                            break;
                        case 8:
                            S = S + " восемь";
                            break;
                        case 9:
                            S = S + " девять";
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine("{0} - \"{1}\" ",Num, S);
            }
        }
    }
}
