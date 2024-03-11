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
            Building build = new Building("Маяковского,6", 16, 37.12, 68.12);
            Console.WriteLine(build.Print());
            
            MultiBuilding build2 = new MultiBuilding("Дубай", 828, 300, 200, 163);
            Console.WriteLine(build2.Print());

            Console.ReadKey();
        }
    }
}
