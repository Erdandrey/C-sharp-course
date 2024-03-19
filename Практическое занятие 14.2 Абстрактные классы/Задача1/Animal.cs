using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();

        public Animal(string name)
        {
            Name = name;
        }
        public void Showinfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
}
