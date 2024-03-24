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
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            Check(s);
            Console.ReadKey();
        }
        static void Check(string s) 
        { 
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> Brackets = new Dictionary<char, char>()
            {
                { '{','}' },
                { '(',')' },
                { '[',']' },

            };
            foreach (char c in s) 
            {
                if (c =='{' || c == '[' || c == '(')
                {
                    stack.Push(Brackets[c]);
                }
                if (c=='}'|| c == ']'|| c == ')' )
                { 
                    if (stack.Count==0 ||stack.Pop() != c)
                    {
                        Console.WriteLine("Скобки расставлены не корректно!"); return; //мне захотелось чтобы метод сам печатал фразу, а не просто выводил true\false
                    }
                }
            }
            if (stack.Count == 0 ) 
            { Console.WriteLine( "Скобки расставлены корректно!"); }
            else { Console.WriteLine("Скобки расставлены не корректно!"); }

        }
    }
}
