using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool flag = true;

        public int Gradus 
        {
            get { return gradus; }
            set 
            {
                if (value < 0)
                {
                    flag = false;
                }
                else
                {
                    gradus = value;
                }
            }
        }
        public int Min
        {
            get { return min; }
            set 
            {
                if (value < 0)
                {
                    flag = false;
                }
                else
                {
                    Gradus = Gradus + value / 60;
                    min = value % 60;
                }
            }
        }
        public int Sec
        {
            get { return sec; }
            set 
            {
                if (value < 0)
                {
                    flag = false;
                }
                else
                {
                    Min = Min + value / 60;
                    sec = value % 60;
                }               
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadians() 
        {
            double rad = gradus*Math.PI/180 + min * Math.PI / 10800 + sec * Math.PI / 648000;
            return rad;
        }
    }
}
