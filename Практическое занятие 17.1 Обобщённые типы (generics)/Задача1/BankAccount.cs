using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class BankAccount <T>
    {
        private T accountType { get; set; }
        private string ownerName { get; set; }
        private double accountBalance { get; set; }

        public void SetInfo()
        {
            Console.WriteLine("Введите тип счёта");
            accountType = (T)(Convert.ChangeType(Console.ReadLine(),typeof(T)));
            Console.WriteLine("Введите ФИО владельца");
            ownerName = Console.ReadLine();
            Console.WriteLine("Введите баланс счёта");
            accountBalance = Convert.ToDouble(Console.ReadLine());
        }

        public string GetInfo()
        {
            return $"Тип счёта: {accountType}\nВладелец счёта: {ownerName}\nБаланс счёта: {accountBalance}";
        }
    }
}
