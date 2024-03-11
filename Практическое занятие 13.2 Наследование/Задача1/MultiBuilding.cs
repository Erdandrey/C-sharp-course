using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal sealed class MultiBuilding:Building
    {
        int floors;

        int Floors 
        {
            get { return floors; } 
            set 
            {
                if (value > 0)
                {
                    floors = value;
                }
            }
        }
        public MultiBuilding(string address, double height, double width, double length, int floors)
            :base(address, height, width, length)
        {
            Floors = floors;
        }

        public string Print()
        {
            string outer = base.Print();
            outer += $"\n - этажей: {floors}";
            return outer;
        }
    }
}
