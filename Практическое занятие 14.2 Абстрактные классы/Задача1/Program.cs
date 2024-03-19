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
            Dog dog = new Dog();
            dog.Showinfo();
            Dog dog2 = new Dog("Немецкая овчарка");
            dog2.Showinfo();
            Cat cat = new Cat("Абиссинская кошка");
            cat.Showinfo();
            Console.ReadKey();
        }
    }
}
