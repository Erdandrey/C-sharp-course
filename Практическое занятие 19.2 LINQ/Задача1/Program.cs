using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>()
            {
                new Computer(){Id=1, Brand="Lenovo", Processor="AMD", ProcessorFrequency=2400, RAMValue=16, Cost=104, AmountAvaliable = 10},
                new Computer(){Id=2, Brand="Asus", Processor="Intel", ProcessorFrequency=1800, RAMValue=32, Cost=120, AmountAvaliable = 5},
                new Computer(){Id=3, Brand="Apple", Processor=" Apple Silicon", ProcessorFrequency=1200, RAMValue=8, Cost=50, AmountAvaliable = 2},
                new Computer(){Id=4, Brand="Samsung", Processor="AMD", ProcessorFrequency=3600, RAMValue=32, Cost=200, AmountAvaliable = 35},
                new Computer(){Id=5, Brand="Lenovo", Processor="Intel", ProcessorFrequency=1800, RAMValue=6, Cost=75, AmountAvaliable = 21},
                new Computer(){Id=6, Brand="Lenovo", Processor="Intel", ProcessorFrequency=2400, RAMValue=16, Cost=100, AmountAvaliable = 15},
                new Computer(){Id=7, Brand="Asus", Processor="MBI", ProcessorFrequency=1600, RAMValue=8, Cost=80, AmountAvaliable = 0},
                new Computer(){Id=8, Brand="HP", Processor="AMD", ProcessorFrequency=2400, RAMValue=16, Cost=110, AmountAvaliable = 8}
            };

            //            -все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.WriteLine("Введите марку процессора");
            string s = Console.ReadLine();
            List<Computer> computers1 = list.Where(a=>a.Processor==s).ToList();
            Print(computers1);
            Console.WriteLine("------");

            //            -все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;
            Console.WriteLine("Введите объём ОЗУ");
            int d  = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = list.Where(a => a.RAMValue >= d).ToList();
            Print(computers2);
            Console.WriteLine("------");

            //            -вывести весь список, отсортированный по увеличению стоимости;
            List<Computer> computers3 = list.OrderBy(a => a.Cost).ToList();
            Print(computers3);
            Console.WriteLine("------");

            //            -вывести весь список, сгруппированный по типу процессора;
            IEnumerable<IGrouping<string,Computer>> computers4 = list.GroupBy(a => a.Processor).ToList();

            foreach (IGrouping<string, Computer> c in computers4)
            {
                Console.WriteLine(c.Key);
                foreach (Computer c2 in c) 
                {
                    PrintOne(c2);
                }
            }
            Console.WriteLine("------");

            //            -найти самый дорогой и самый бюджетный компьютер;
            Computer computer5 = list.OrderByDescending(a => a.Cost).FirstOrDefault();
            Console.WriteLine("Самый дорогой:");
            PrintOne(computer5);
            Computer computer6 = list.OrderBy(a => a.Cost).FirstOrDefault();
            Console.WriteLine("Самый дешёвый:");
            PrintOne(computer6);
            Console.WriteLine("------");

            //                -есть ли хотя бы один компьютер в количестве не менее 30 штук?
            if (list.Any(a=>a.AmountAvaliable>=30)) 
            {
                Console.WriteLine("Есть в наличии 30+ штук");
            }
            else
            {
                Console.WriteLine("Нет в наличии 30+ штук");
            }


            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer computer in computers) 
            { 
                PrintOne(computer);
            }
        }

        static void PrintOne(Computer computer)
        {
                Console.WriteLine($"{computer.Id} {computer.Brand} {computer.Processor} {computer.ProcessorFrequency} {computer.RAMValue} {computer.Cost} {computer.AmountAvaliable}");
        }
    }
}
