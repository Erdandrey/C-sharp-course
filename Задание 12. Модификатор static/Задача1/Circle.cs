using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal static class Circle
    {
       static public double GetLength(double r)
        {
            return 2 * r * Math.PI;
        }

         static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }

         static public void BelongsToCircle(double r, double x, double y, double x0, double y0)
        {
            if (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= r * r)
            {
                Console.WriteLine("Принадлежит");
            }
            else
            {
                Console.WriteLine("Не принадлежит");
            }
        }
    }
}
