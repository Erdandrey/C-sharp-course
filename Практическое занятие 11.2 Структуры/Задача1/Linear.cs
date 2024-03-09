using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal struct Linear
    {
        double k;
        double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            return $"Корень уравнения: {-b/k}";
        }
    }
}
