using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class ArithProgression : ISeries
    {
        int Counter;
        int Starter;
        int Step;
        public int GetNext()
        {
            Counter += Step;
            return Counter;
        }

        public void Reset()
        {
            Counter = Starter;
        }

        public void SetStart(int x)
        {
            Starter = x;
            Counter = Starter;
        }
        public void SetStep(int x)
        {
            Step = x;
        }
    }
}
