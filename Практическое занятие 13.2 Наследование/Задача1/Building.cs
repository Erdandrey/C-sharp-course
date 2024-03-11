using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Building
    {
        string address;
        double height;
        double width;
        double length;

        string Address
        {
            get { return address; }
            set { address = value; }
        }

        double Height 
        { 
            get { return height; } 
            set 
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }

        double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }

        public Building(string address,  double height, double width, double length)
        {
            Address = address;
            Height = height;
            Width = width;
            Length = length;
        }

        public string Print () 
        {
            return $"Адрес здания: {address}  \n - высота: {height} метров\n - ширина: {width} метров\n - длина:  {length} метров";
        }

    }
}
