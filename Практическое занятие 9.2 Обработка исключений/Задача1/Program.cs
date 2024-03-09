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
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.WriteLine("Введите первое число");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double second = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите код операции: \n 1 - сложение \n 2 - вычитание \n 3 - произведение \n 4 - частное");
                int operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", operation);
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Результат: {0}", first + second);
                        break;
                    case 2:
                        Console.WriteLine("Результат: {0}", first - second);
                        break;
                    case 3:
                        Console.WriteLine("Результат: {0}", first * second);
                        break;
                    case 4:
                        Console.WriteLine("Результат: {0}", first / second); // это очень странно, но с типом double он не ругается на деление на ноль, а выводит ?. Даже добавление отдельного обработчика DivideByZero не срабатывает
                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
