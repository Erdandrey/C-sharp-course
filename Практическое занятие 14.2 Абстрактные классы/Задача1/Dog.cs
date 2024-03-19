﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Dog : Animal
    {
        private string name;
        public override string Name 
        { 
          get => name;
          set => name = value;
        }

        public Dog(string name = "Неизвестный науке зверь")
            : base(name) { }


        public override void Say()
        {
            Console.WriteLine("Гав-гав!");
        }
    }
}
