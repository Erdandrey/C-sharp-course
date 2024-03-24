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
            BankAccount<int> acc1 = new BankAccount<int>();
            acc1.SetInfo();
            Console.WriteLine(acc1.GetInfo());

            BankAccount<string> acc2 = new BankAccount<string>();
            acc2.SetInfo();
            Console.WriteLine(acc2.GetInfo());

            Console.ReadKey();
        }
    }
}
